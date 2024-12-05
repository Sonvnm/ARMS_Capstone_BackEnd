using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ARMS_API.Controllers.SchoolService;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.AccountSer;
using Service.EmailSer;

namespace Test.SchoolService
{
    [TestClass]
    public class SendEmailControllerTests
    {
        private Mock<IEmailService> _mockEmailService;
        private Mock<IAccountService> _mockAccountService;
        private Mock<IRequestNotificationService> _mockRequestNotificationService;
        private Mock<EmailQueue> _mockEmailQueue;
        private SendEmailController _controller;

        public SendEmailControllerTests()
        {
            _mockEmailService = new Mock<IEmailService>();
            _mockAccountService = new Mock<IAccountService>();
            _mockEmailQueue = new Mock<EmailQueue>();
            _mockRequestNotificationService = new Mock<IRequestNotificationService>();
            _controller = new SendEmailController(
                _mockEmailService.Object,
                _mockAccountService.Object,
                _mockEmailQueue.Object,
                _mockRequestNotificationService.Object);
        }

        [TestMethod]
        public async Task GetRequest_ShouldReturnOk_WhenUserIsFound()
        {
            // Arrange
            var userId = Guid.NewGuid().ToString();
            var requestNotification = new List<RequestNotification>
            {
                new RequestNotification { Content = "Test notification", Subject = "Subject", TimeSend = DateTime.Now }
            };

            _controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext()
                {
                    User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userId)
                }))
                }
            };

            _mockRequestNotificationService.Setup(x => x.GetRequests(It.IsAny<Guid>()))
                .ReturnsAsync(requestNotification);

            // Act
            var result = await _controller.GetRequest();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var returnValue = okResult.Value as List<RequestNotification>;
            Assert.IsNotNull(returnValue);
            Assert.IsTrue(returnValue.Count > 0);
        }

        [TestMethod]
        public async Task GetRequest_ShouldReturnUnauthorized_WhenUserIdIsNotFound()
        {
            // Arrange
            _controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext() { User = new ClaimsPrincipal() }
            };

            // Act
            var result = await _controller.GetRequest();

            // Assert
            var unauthorizedResult = result as UnauthorizedObjectResult;
            Assert.IsNotNull(unauthorizedResult);
            Assert.AreEqual("Không tìm thấy ID người dùng!", unauthorizedResult.Value);
        }
    }
}
