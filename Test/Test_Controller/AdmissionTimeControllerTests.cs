using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Service.AdmissionTimeSer;
using ARMS_API.Controllers;
using Data.Models;
using Data.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test.Test_Controller
{
    [TestClass]
    public class AdmissionTimeControllerTests
    {
        private Mock<IAdmissionTimeService> _mockAdmissionTimeService;
        private Mock<IMapper> _mockMapper;
        private AdmissionTimeController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockAdmissionTimeService = new Mock<IAdmissionTimeService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new AdmissionTimeController(_mockAdmissionTimeService.Object, _mockMapper.Object);
        }

        [TestMethod]
        public async Task GetAdmissionTimes_ValidCampusId_ReturnsOkResultWithMappedDTO()
        {
            // Arrange
            string campusId = "Campus1";
            var admissionTimes = new List<AdmissionTime>
            {
                new AdmissionTime
                {
                    AdmissionTimeId = 1,
                    AdmissionTimeName = "Fall 2024",
                    StartRegister = new DateTime(2024, 6, 1),
                    EndRegister = new DateTime(2024, 6, 30)
                }
            };

            var admissionTimeDTOs = new List<AdmissionTimeDTO>
            {
                new AdmissionTimeDTO
                {
                    AdmissionTimeId = 1,
                    AdmissionTimeName = "Fall 2024",
                    StartRegister = new DateTime(2024, 6, 1),
                    EndRegister = new DateTime(2024, 6, 30)
                }
            };

            _mockAdmissionTimeService.Setup(service => service.GetAdmissionTimes(campusId))
                                     .ReturnsAsync(admissionTimes);

            _mockMapper.Setup(mapper => mapper.Map<List<AdmissionTimeDTO>>(admissionTimes))
                       .Returns(admissionTimeDTOs);

            // Act
            var result = await _controller.GetAdmissionTimes(campusId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            var actualResult = okResult.Value as List<AdmissionTimeDTO>;
            Assert.AreEqual(admissionTimeDTOs.Count, actualResult.Count);
            Assert.AreEqual(admissionTimeDTOs[0].AdmissionTimeName, actualResult[0].AdmissionTimeName);
        }

        [TestMethod]
        public async Task GetAdmissionTimes_ServiceThrowsException_ReturnsBadRequest()
        {
            // Arrange
            var campusId = "Campus1";
            _mockAdmissionTimeService.Setup(s => s.GetAdmissionTimes(campusId)).ThrowsAsync(new System.Exception());

            // Act
            var result = await _controller.GetAdmissionTimes(campusId);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);
        }
    }
}
