using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Service.AdmissionInformationSer;
using System;
using System.Threading.Tasks;
using ARMS_API.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ARMS_API.Controllers.AdmissionCouncil;
using ARMS_API.Controllers.Admission_Council;

namespace Test_Controller
{
    [TestClass]
    public class AdmissionInformationControllerTests
    {
        private Mock<IAdmissionInformationService> _mockAdmissionInformationService;
        private Mock<IMapper> _mockMapper;
        private AdmissionInformationController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockAdmissionInformationService = new Mock<IAdmissionInformationService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new AdmissionInformationController(_mockAdmissionInformationService.Object, _mockMapper.Object);
        }

        [TestMethod]
        public async Task GetAdmissionInformation_ValidCampusId_ReturnsOkResultWithMappedDTO()
        {
            // Arrange
            string campusId = "Campus1";
            var admissionInformation = new AdmissionInformation
            {
                AdmissionInformationID = 1,
                // other properties initialization
            };

            var admissionInformationDTO = new AdmissionInformationDTO
            {
                AdmissionInformationID = 1,
                // other properties initialization
            };

            // Mock the service to return the admission information
            _mockAdmissionInformationService.Setup(service => service.GetAdmissionInformationProcess(campusId))
                .ReturnsAsync(admissionInformation);

            // Mock the AutoMapper to map the model to DTO
            _mockMapper.Setup(mapper => mapper.Map<AdmissionInformationDTO>(admissionInformation))
                .Returns(admissionInformationDTO);

            // Act
            var result = await _controller.GetAdmissionInformation(campusId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            var actualResult = okResult.Value as AdmissionInformationDTO;
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(admissionInformationDTO.AdmissionInformationID, actualResult.AdmissionInformationID);
        }

        [TestMethod]
        public async Task GetAdmissionInformation_NoAdmissionInformation_ReturnsBadRequest()
        {
            // Arrange
            string campusId = "Campus2";

            // Mock the service to return null
            _mockAdmissionInformationService.Setup(service => service.GetAdmissionInformationProcess(campusId))
                .ReturnsAsync((AdmissionInformation)null);

            // Act
            var result = await _controller.GetAdmissionInformation(campusId);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);
            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Đã hết đợt tuyển sinh!", response.Message);
        }

        [TestMethod]
        public async Task GetAdmissionInformation_Exception_ReturnsBadRequest()
        {
            // Arrange
            string campusId = "Campus1";

            // Mock the service to throw an exception
            _mockAdmissionInformationService.Setup(service => service.GetAdmissionInformationProcess(campusId))
                .ThrowsAsync(new Exception());

            // Act
            var result = await _controller.GetAdmissionInformation(campusId);

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
