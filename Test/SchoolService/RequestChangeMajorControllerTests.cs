using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS_API.Controllers.SchoolService;
using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test.SchoolService
{
    [TestClass]
    public class RequestChangeMajorControllerTests
    {
        private Mock<IRequestService> _mockRequestChangeMajorService;
        private Mock<IMapper> _mockMapper;
        private Mock<UserInput> _mockUserInput;
        private RequestChangeMajorController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockRequestChangeMajorService = new Mock<IRequestService>();
            _mockMapper = new Mock<IMapper>();
            _mockUserInput = new Mock<UserInput>();
            _controller = new RequestChangeMajorController(
                _mockRequestChangeMajorService.Object,
                _mockMapper.Object,
                _mockUserInput.Object);
        }

        [TestMethod]
        public async Task GetRequestChangeMajor_ShouldReturnOk_WhenValidDataIsProvided()
        {
            // Arrange
            var campusId = "Campus123";
            var search = "Test";
            var currentPage = 1;
            var status = TypeofRequestChangeMajor.Inprocess;

            var requestList = new List<Request>
            {
                new Request
                {
                    Description = "Test description",
                    MajorNew = "New Major",
                    Account = new Account { Fullname = "Nguyễn Văn A", StudentCode = "12345" },
                    MajorO = new Major { MajorName = "Old Major" },
                    MajorN = new Major { MajorName = "New Major" },
                    Status = status
                }
            };

            // Setup mocks
            _mockRequestChangeMajorService.Setup(s => s.GetRequestChangeMajors(campusId)).ReturnsAsync(requestList);
            // Act
            var result = await _controller.GetRequestChangeMajor(campusId, search, currentPage, status);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

            var response = okResult.Value as ResponeModel<RequestChangeMajor_SS_DTO>;
            Assert.IsNotNull(response);
            Assert.AreEqual(1, response.TotalItems);
        }


        [TestMethod]
        public async Task GetRequestChangeMajor_ShouldReturnBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var campusId = "Campus123";
            var search = "Test Search";
            var currentPage = 1;
            var status = TypeofRequestChangeMajor.Accept;

            _mockRequestChangeMajorService.Setup(s => s.GetRequestChangeMajors(campusId)).ThrowsAsync(new Exception("An error occurred"));

            // Act
            var result = await _controller.GetRequestChangeMajor(campusId, search, currentPage, status);

            // Assert
            var badRequestResult = result as BadRequestResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);
        }
        [TestMethod]
        public async Task AddRequest_ShouldReturnOk_WhenRequestIsSuccessfullyUpdated()
        {
            // Arrange
            var requestID = 1;
            var replyRequestDTO = new Reply_Request_DTO
            {
                Status = TypeofRequestChangeMajor.Accept,
                Reply = "Request approved"
            };

            var request = new Request
            {
                RequestID = requestID,
                Status = TypeofRequestChangeMajor.Inprocess,
                Reply = null
            };

            _mockRequestChangeMajorService.Setup(service => service.GetRequestByID(requestID))
                .ReturnsAsync(request);
            _mockRequestChangeMajorService.Setup(service => service.UpdateRequest(It.IsAny<Request>()))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _controller.AddRequest(requestID, replyRequestDTO);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

            var response = okResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Chỉnh sửa thành công!", response.Message);
        }

        [TestMethod]
        public async Task AddRequest_ShouldReturnBadRequest_WhenAnExceptionOccurs()
        {
            // Arrange
            var requestID = 1;
            var replyRequestDTO = new Reply_Request_DTO
            {
                Status = TypeofRequestChangeMajor.Accept,
                Reply = "Request approved"
            };
            var exceptionMessage = "Database error";
            _mockRequestChangeMajorService.Setup(service => service.GetRequestByID(requestID))
                .ThrowsAsync(new Exception(exceptionMessage));

            // Act
            var result = await _controller.AddRequest(requestID, replyRequestDTO);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);

            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual(exceptionMessage, response.Message);
        }
    }
}
