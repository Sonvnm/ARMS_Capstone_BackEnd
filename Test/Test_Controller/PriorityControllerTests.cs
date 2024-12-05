using Microsoft.AspNetCore.Mvc;
using Moq;
using AutoMapper;
using ARMS_API.Controllers;
using Service.PriorityService;
using Data.DTO;
using Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Test.Test_Controller
{
    [TestClass]
    public class PriorityControllerTests
    {
        private Mock<IPriorityService> _mockPriorityService;
        private Mock<IMapper> _mockMapper;
        private PriorityController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockPriorityService = new Mock<IPriorityService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new PriorityController(_mockPriorityService.Object, _mockMapper.Object);
        }

        [TestMethod]
        public async Task GetPriorities_ShouldReturnOk_WhenDataIsValid()
        {
            // Arrange
            var priorityDetails = new List<PriorityDetail>
            {
                new PriorityDetail { PriorityID = 1, PriorityName = "UT1" },
                new PriorityDetail { PriorityID = 2, PriorityName = "UT2" }
            };

            var priorityDTOs = new List<PriorityDTO>
            {
                new PriorityDTO { PriorityID = 1, PriorityName = "UT1" },
                new PriorityDTO { PriorityID = 2, PriorityName = "UT2" }
            };

            _mockPriorityService.Setup(s => s.GetPriorities()).ReturnsAsync(priorityDetails);
            _mockMapper.Setup(m => m.Map<List<PriorityDTO>>(priorityDetails)).Returns(priorityDTOs);

            // Act
            var result = await _controller.GetPriorities();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var returnValue = okResult.Value as List<PriorityDTO>;
            Assert.IsNotNull(returnValue);
            Assert.AreEqual(2, returnValue.Count);
            Assert.AreEqual("UT1", returnValue[0].PriorityName);
            Assert.AreEqual("UT2", returnValue[1].PriorityName);
        }

        [TestMethod]
        public async Task GetPriorities_ShouldReturnBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            _mockPriorityService.Setup(s => s.GetPriorities()).ThrowsAsync(new System.Exception());

            // Act
            var result = await _controller.GetPriorities();

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Đã xảy ra lỗi! Vui lòng thử lại sau!", response.Message);
        }
    }
}
