using ARMS_API.Controllers.SchoolService;
using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.BlogSer;
using Service.StudentProfileServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SchoolService
{
    [TestClass]
    public class BlogControllerTests
    {
        private Mock<IBlogService> _mockBlogService;
        private Mock<UserInput> _mockUserInput;
        private Mock<IStudentProfileService> _mockStudentProfileService;
        private ValidBlog _validBlog;
        private IMapper _mapper;
        private BlogController _controller;
        [TestInitialize]
        public void Setup()
        {
            _mockBlogService = new Mock<IBlogService>();
            _mockUserInput = new Mock<UserInput>();
            _mockStudentProfileService = new Mock<IStudentProfileService>();

            _validBlog = new ValidBlog(_mockUserInput.Object, _mockStudentProfileService.Object);

            var mockMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Blog_SS_DTO, Blog>();
            });
            _mapper = mockMapperConfig.CreateMapper();

            _controller = new BlogController(_mockBlogService.Object, _mapper, _validBlog);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "Không nhận được dữ liệu!")]
        public void InputBlog_ShouldThrowException_WhenBlogDTOIsNull()
        {
            // Act
            _validBlog.InputBlog(null);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "Không được để trống nội dung bài viết!")]
        public void InputBlog_ShouldThrowException_WhenContentIsNullOrEmpty()
        {
            // Arrange
            var blogDTO = new Blog_SS_DTO
            {
                Title = "Test Title",
                Content = "",  // Empty content
                Description = "Test Description",
                BlogCategoryId = 1
            };

            // Act
            _validBlog.InputBlog(blogDTO);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "Không được để trống tiêu đề bài viết!")]
        public void InputBlog_ShouldThrowException_WhenTitleIsNullOrEmpty()
        {
            // Arrange
            var blogDTO = new Blog_SS_DTO
            {
                Title = "",  // Empty title
                Content = "Test Content",
                Description = "Test Description",
                BlogCategoryId = 1
            };

            // Act
            _validBlog.InputBlog(blogDTO);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "Không được để trống mô tả bài viết!")]
        public void InputBlog_ShouldThrowException_WhenDescriptionIsNullOrEmpty()
        {
            // Arrange
            var blogDTO = new Blog_SS_DTO
            {
                Title = "Test Title",
                Content = "Test Content",
                Description = "",  // Empty description
                BlogCategoryId = 1
            };

            // Act
            _validBlog.InputBlog(blogDTO);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "Vui lòng chọn loại bài viết!")]
        public void InputBlog_ShouldThrowException_WhenBlogCategoryIdIsZero()
        {
            // Arrange
            var blogDTO = new Blog_SS_DTO
            {
                Title = "Test Title",
                Content = "Test Content",
                Description = "Test Description",
                BlogCategoryId = 0  // Invalid BlogCategoryId
            };

            // Act
            _validBlog.InputBlog(blogDTO);
        }
        [TestMethod]
        public void InputBlog_ShouldNotThrowException_WhenDataIsValid()
        {
            // Arrange
            var blogDTO = new Blog_SS_DTO
            {
                Title = "Valid Title",
                Content = "Valid Content",
                Description = "Valid Description",
                BlogCategoryId = 1
            };
            _validBlog.InputBlog(blogDTO);
        }
        [TestMethod]
        public async Task AddBlog_ShouldReturnOk_WhenValidDataIsProvided()
        {
            // Arrange
            var blogDTO = new Blog_SS_DTO
            {
                BlogId = 1,
                Title = "Valid Blog Title",
                Content = "Valid Blog Content",
                Description = "Valid Blog Description",
                BlogCategoryId = 1
            };
            _mockBlogService.Setup(s => s.AddNewBlog(It.IsAny<Blog>())).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.AddBlog(blogDTO);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

            var response = okResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status); 
            Assert.AreEqual("Tạo mới mới thành công!", response.Message);  
        }
        [TestMethod]
        public async Task AddBlog_ShouldReturnBadRequest_WhenInvalidDataIsProvided()
        {
            // Arrange
            var blogDTO = new Blog_SS_DTO
            {
                BlogId = 1,
                Title = "", 
                Content = "Valid Blog Content",
                Description = "Valid Blog Description",
                BlogCategoryId = 1
            };

            // Act
            var result = await _controller.AddBlog(blogDTO);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode); 

            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);  // Ensure failure status
            Assert.AreEqual("Không được để trống tiêu đề bài viết!", response.Message);
        }
        [TestMethod]
        public async Task UpdateBlog_ShouldReturnOk_WhenValidDataIsProvided()
        {
            // Arrange
            var blogDTO = new Blog_SS_DTO
            {
                BlogId = 1,
                Title = "Updated Blog Title",
                Content = "Updated Blog Content",
                Description = "Updated Blog Description",
                BlogCategoryId = 1
            };
            _mockBlogService.Setup(s => s.UpdateBlog(It.IsAny<Blog>())).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.UpdateBlog(blogDTO);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

            var response = okResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Cập nhật thành công!", response.Message);  
        }

        [TestMethod]
        public async Task UpdateBlog_ShouldReturnBadRequest_WhenInvalidDataIsProvided()
        {
            // Arrange
            var blogDTO = new Blog_SS_DTO
            {
                BlogId = 1,
                Title = "",
                Content = "Updated Blog Content",
                Description = "Updated Blog Description",
                BlogCategoryId = 1
            };

            // Act
            var result = await _controller.UpdateBlog(blogDTO);

            // Assert
            var badRequestResult = result as BadRequestResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode); 
        }
    }
}
