using ARMS_API.Controllers.AdmissionCouncil;
using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.AdmissionInformationSer;
using Service.AdmissionTimeSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AdmissionCouncil
{
    [TestClass]
    public class AdmissionTimeControllerTests
    {
        private Mock<IAdmissionTimeService> _mockAdmissionTimeService;
        private Mock<IAdmissionInformationService> _mockAdmissionInformationService;
        private Mock<IMapper> _mockMapper;
        private ValidAdmissionTime _mockValidAdmissionTime;
        private AdmissionTimeController _controller;
        private Mock<UserInput> _mockUserInput;
        [TestInitialize]
        public void TestInitialize()
        {
            _mockAdmissionTimeService = new Mock<IAdmissionTimeService>();
            _mockMapper = new Mock<IMapper>();
            _mockUserInput = new Mock<UserInput>();
            _mockAdmissionInformationService = new Mock<IAdmissionInformationService>();
            _mockValidAdmissionTime = new ValidAdmissionTime(_mockUserInput.Object, _mockAdmissionInformationService.Object);
            _controller = new AdmissionTimeController(
                _mockAdmissionTimeService.Object,
                _mockMapper.Object,
                _mockValidAdmissionTime
            );
        }

        [TestMethod]
        public async Task GetAdmissionTimes_ReturnsOk_WhenDataFound()
        {
            // Arrange
            var campusId = "campus-1";
            var year = 2024;
            var admissionTimes = new List<AdmissionTime>();
            var admissionTimeDtos = new List<AdmissionTime_Admission_DTO>();

            _mockAdmissionTimeService.Setup(service => service.GetAdmissionTimes(campusId))
                                      .ReturnsAsync(admissionTimes);
            _mockMapper.Setup(mapper => mapper.Map<List<AdmissionTime_Admission_DTO>>(admissionTimes))
                       .Returns(admissionTimeDtos);

            // Act
            var result = await _controller.GetAdmissionTimes(campusId, year);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.AreEqual(admissionTimeDtos, okResult.Value);
        }

        [TestMethod]
        public async Task GetAdmissionTimes_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var campusId = "campus-1";
            var year = 2024;
            _mockAdmissionTimeService.Setup(service => service.GetAdmissionTimes(campusId))
                                      .ThrowsAsync(new Exception("Something went wrong"));

            // Act
            var result = await _controller.GetAdmissionTimes(campusId, year);

            // Assert
            var badRequestResult = result as BadRequestResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);
        }

    }
}
