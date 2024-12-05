using ARMS_API.Controllers;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Service.BlogSer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ARMS_API.ValidData;

namespace ARMS_API.Tests
{
    [TestClass]
    public class BlogControllerTests
    {
        private Mock<IBlogService> _mockBlogService;
        private Mock<IMapper> _mockMapper;
        private BlogController _controller;
        private Mock<UserInput> _mockUserInput;
        [TestInitialize]
        public void Setup()
        {
            _mockUserInput = new Mock<UserInput>();
            _mockBlogService = new Mock<IBlogService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new BlogController(_mockBlogService.Object, _mockMapper.Object, _mockUserInput.Object); // Assuming UserInput is null for simplicity
        }

        [TestMethod]
        public async Task GetBlogCategories_ReturnsOkResult_WithValidData()
        {
            // Arrange
            var campusId = "Campus123";
            var blogCategories = new List<BlogCategory>
            {
                new BlogCategory { BlogCategoryId = 1, BlogCategoryName = "Category1" },
                new BlogCategory { BlogCategoryId = 2, BlogCategoryName = "Category2" }
            };

            var blogCategoryDTOs = new List<BlogCategoryDTO>
            {
                new BlogCategoryDTO { BlogCategoryId = 1, BlogCategoryName = "Category1" },
                new BlogCategoryDTO { BlogCategoryId = 2, BlogCategoryName = "Category2" }
            };

            _mockBlogService.Setup(service => service.GetBlogCategories(campusId))
                .ReturnsAsync(blogCategories);

            _mockMapper.Setup(mapper => mapper.Map<List<BlogCategoryDTO>>(blogCategories))
                .Returns(blogCategoryDTOs);

            // Act
            var result = await _controller.GetBlogCategories(campusId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            var returnValue = okResult.Value as List<BlogCategoryDTO>;
            Assert.IsNotNull(returnValue);
            Assert.AreEqual(2, returnValue.Count);
        }
        [TestMethod]
        public async Task GetBlogCategories_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var campusId = "Campus123";
            _mockBlogService.Setup(service => service.GetBlogCategories(campusId))
                .ThrowsAsync(new Exception("Simulated exception"));

            // Act
            var result = await _controller.GetBlogCategories(campusId);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);

            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Đã xảy ra lỗi! Vui lòng thử lại sau!", response.Message);
        }

        [TestMethod]
        public async Task GetBlogs_ReturnsOkResult_WithFilteredBlogs()
        {
            // Arrange
            var campusId = "Campus123";
            var search = "test";
            var currentPage = 1;
            var categoryId = 1;
            var blogs = new List<Blog>
            {
                new Blog { BlogId = 1, Title = "Test Blog 1", Description = "Description 1", BlogCategoryId = categoryId },
                new Blog { BlogId = 2, Title = "Test Blog 2", Description = "Description 2", BlogCategoryId = categoryId },
                new Blog { BlogId = 3, Title = "Another Blog", Description = "Description 3", BlogCategoryId = categoryId }
            };

            var blogDTOs = new List<BlogDTO>
            {
                new BlogDTO { BlogId = 1, Title = "Test Blog 1", Description = "Description 1" },
                new BlogDTO { BlogId = 2, Title = "Test Blog 2", Description = "Description 2" }
            };

            _mockBlogService.Setup(service => service.GetBlogs(campusId))
                .ReturnsAsync(blogs);

            _mockMapper.Setup(mapper => mapper.Map<List<BlogDTO>>(It.IsAny<List<Blog>>()))
                .Returns(blogDTOs);

            // Act
            var result = await _controller.GetBlogs(campusId, search, currentPage, categoryId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            var response = okResult.Value as ResponeModel<BlogDTO>;
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.Item.Count);
        }
        [TestMethod]
        public async Task GetBlogs_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var campusId = "Campus123";
            var search = "sample search";
            var currentPage = 1;
            var categoryId = 1;
            _mockBlogService.Setup(service => service.GetBlogs(campusId))
                .ThrowsAsync(new Exception("Simulated exception"));

            // Act
            var result = await _controller.GetBlogs(campusId, search, currentPage, categoryId);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);

            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Đã xảy ra lỗi! Vui lòng thử lại sau!", response.Message);
        }

        [TestMethod]
        public async Task GetBlog_ReturnsNotFoundResult_WhenBlogNotFound()
        {
            // Arrange
            var blogId = 999;
            _mockBlogService.Setup(service => service.GetBlog(blogId))
                .ReturnsAsync((Blog)null);  // Blog not found

            // Act
            var result = await _controller.GetBlog(blogId);

            // Assert
            var notFoundResult = result as NotFoundResult;
            Assert.IsNotNull(notFoundResult);
            Assert.AreEqual(404, notFoundResult.StatusCode);
        }
        [TestMethod]
        public async Task GetBlog_ReturnsNotFound_WhenBlogDoesNotExist()
        {
            // Arrange
            var blogId = 999;

            _mockBlogService.Setup(service => service.GetBlog(blogId))
                .ReturnsAsync((Blog)null);

            // Act
            var result = await _controller.GetBlog(blogId);

            // Assert
            var notFoundResult = result as NotFoundResult;
            Assert.IsNotNull(notFoundResult);
            Assert.AreEqual(404, notFoundResult.StatusCode);
        }

        [TestMethod]
        public async Task GetTop5Blogs_ReturnsOkResult_WithValidData()
        {
            // Arrange
            var campusId = "Campus123";
            var blogCategoryId = 1;
            var blogs = new List<Blog>
            {
                new Blog { BlogId = 1, Title = "Top Blog 1", BlogCategoryId = blogCategoryId },
                new Blog { BlogId = 2, Title = "Top Blog 2", BlogCategoryId = blogCategoryId },
                new Blog { BlogId = 3, Title = "Top Blog 3", BlogCategoryId = blogCategoryId },
                new Blog { BlogId = 4, Title = "Top Blog 4", BlogCategoryId = blogCategoryId },
                new Blog { BlogId = 5, Title = "Top Blog 5", BlogCategoryId = blogCategoryId },
                new Blog { BlogId = 6, Title = "Extra Blog", BlogCategoryId = blogCategoryId }
            };

            var blogDTOs = new List<BlogDTO>
            {
                new BlogDTO { BlogId = 1, Title = "Top Blog 1" },
                new BlogDTO { BlogId = 2, Title = "Top Blog 2" },
                new BlogDTO { BlogId = 3, Title = "Top Blog 3" },
                new BlogDTO { BlogId = 4, Title = "Top Blog 4" },
                new BlogDTO { BlogId = 5, Title = "Top Blog 5" }
            };

            _mockBlogService.Setup(service => service.GetBlogs(campusId))
                .ReturnsAsync(blogs);

            _mockMapper.Setup(mapper => mapper.Map<List<BlogDTO>>(It.IsAny<List<Blog>>()))
                .Returns(blogDTOs);

            // Act
            var result = await _controller.GetBlogs(campusId, null, 1, blogCategoryId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            var response = okResult.Value as ResponeModel<BlogDTO>;
            Assert.IsNotNull(response);
            Assert.AreEqual(5, response.Item.Count);
        }
        [TestMethod]
        public async Task GetTop5Blogs_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var campusId = "Campus1";
            var blogCategoryId = 1;
            _mockBlogService.Setup(service => service.GetBlogs(campusId))
                .ThrowsAsync(new Exception("Simulated exception"));

            // Act
            var result = await _controller.GetBlogs(campusId, blogCategoryId);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);

            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Đã xảy ra lỗi! Vui lòng thử lại sau!", response.Message);
        }

    }
}
