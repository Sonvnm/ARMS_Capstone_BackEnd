using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS_API.Controllers.AdmissionCouncil;
using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.MajorSer;

namespace Test.AdmissionCouncil
{
    [TestClass]
    public class MajorController_AC_Test
    {
        private Mock<IMajorService> _mockMajorService;
        private Mock<IMapper> _mockMapper;
        private ValidMajor _ValidMajor;
        private Mock<UserInput> _mockUserInput;
        private MajorController _controller;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockMajorService = new Mock<IMajorService>();
            _mockMapper = new Mock<IMapper>();
            _mockUserInput = new Mock<UserInput>();
            _ValidMajor = new ValidMajor(_mockUserInput.Object, _mockMajorService.Object);

            _controller = new MajorController(
                _mockMajorService.Object,
                _mockMapper.Object,
                _ValidMajor,
                _mockUserInput.Object
            );
        }
        [TestMethod]
        public async Task UpdateMajor_ReturnsOk_WhenUpdateIsSuccessful()
        {
            // Arrange
            var majorDto = new Major_Admission_DTO();
            var majorAdmission = new MajorAdmission();
            _mockMapper.Setup(m => m.Map<MajorAdmission>(It.IsAny<Major_Admission_DTO>())).Returns(majorAdmission);
            _mockMajorService.Setup(s => s.UpdateMajorAdmission(It.IsAny<MajorAdmission>())).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.UpdateMajor(majorDto);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            var response = okResult.Value as ResponseViewModel;
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Cập nhật thành công!", response.Message);
        }

        [TestMethod]
        public async Task UpdateMajor_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var majorDto = new Major_Admission_DTO();
            var majorAdmission = new MajorAdmission();
            _mockMapper.Setup(m => m.Map<MajorAdmission>(It.IsAny<Major_Admission_DTO>())).Returns(majorAdmission);
            _mockMajorService.Setup(s => s.UpdateMajorAdmission(It.IsAny<MajorAdmission>())).Throws(new Exception());

            // Act
            var result = await _controller.UpdateMajor(majorDto);

            // Assert
            var badRequestResult = result as BadRequestResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);
        }

        [TestMethod]
        public async Task AddMajor_ReturnsOk_WhenAddIsSuccessful()
        {
            // Arrange
            var majorDto = new Major_Admission_DTO();
            var majorAdmission = new MajorAdmission();
            _mockMapper.Setup(m => m.Map<MajorAdmission>(It.IsAny<Major_Admission_DTO>())).Returns(majorAdmission);
            _mockMajorService.Setup(s => s.AddMajorAdmision(It.IsAny<MajorAdmission>())).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.AddMajor(majorDto);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            var response = okResult.Value as ResponseViewModel;
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Thêm ngành tuyển sinh thành công!", response.Message);
        }

        [TestMethod]
        public async Task AddMajor_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var majorDto = new Major_Admission_DTO();
            var majorAdmission = new MajorAdmission();
            _mockMapper.Setup(m => m.Map<MajorAdmission>(It.IsAny<Major_Admission_DTO>())).Returns(majorAdmission);
            _mockMajorService.Setup(s => s.AddMajorAdmision(It.IsAny<MajorAdmission>())).Throws(new Exception());

            // Act
            var result = await _controller.AddMajor(majorDto);

            // Assert
            var badRequestResult = result as BadRequestResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);
        }

        [TestMethod]
        public async Task GetMajors_ReturnsOk_WhenMajorsAreFound()
        {
            // Arrange
            var majorDtoList = new List<MajorDTO> { new MajorDTO() };
            var majorAdmissionList = new List<MajorAdmission> { new MajorAdmission(){
                Major = new Major()
                {
                    isVocationalSchool = true,
                    MajorID = "Test",
                    MajorName = "Test",
                    CampusId = "Test",
                    MajorCode = "Test"
                }
            } };
            _mockMajorService.Setup(s => s.GetMajorsManage(It.IsAny<string>())).ReturnsAsync(majorAdmissionList);
            _mockMapper.Setup(m => m.Map<List<MajorDTO>>(It.IsAny<List<MajorAdmission>>())).Returns(majorDtoList);

            // Act
            var result = await _controller.GetMajors("campus1", true, "majorSearch", 1);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            var response = okResult.Value as ResponeModel<MajorDTO>;
            Assert.AreEqual(1, response.Item.Count);
        }

        [TestMethod]
        public async Task GetMajors_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            _mockMajorService.Setup(s => s.GetMajorsManage(It.IsAny<string>())).Throws(new Exception());

            // Act
            var result = await _controller.GetMajors("campus1", true, "majorSearch", 1);

            // Assert
            var badRequestResult = result as BadRequestResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);
        }
        [TestMethod]
        public async Task GetMajorDetail_ReturnsOk_WhenMajorFound()
        {
            // Arrange
            var majorId = "test-major-id";
            var majorAdmission = new MajorAdmission
            {
                MajorID = "Test",
                Status = true,
                SubjectGroupsJson = "[1,2]",
                TotalScoreAcademic = 24,
                TotalScore = 24,
                AdmissionTimeId = 1
            };
            var majorDTO = new MajorDTO
            {
                TotalScore = 24,
                TotalScoreAcademic = 24,
                Status = true,
                isVocationalSchool = true,
                MajorID = "Test"
            };

            _mockMajorService.Setup(service => service.GetMajorDetail(majorId))
                             .ReturnsAsync(majorAdmission);
            _mockMapper.Setup(mapper => mapper.Map<MajorDTO>(majorAdmission))
                       .Returns(majorDTO);

            // Act
            var result = await _controller.GetMajorDetail(majorId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.AreEqual(majorDTO, okResult.Value);
        }

        [TestMethod]
        public async Task GetMajorDetail_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var majorId = "test-major-id";
            _mockMajorService.Setup(service => service.GetMajorDetail(majorId))
                             .ThrowsAsync(new Exception("Database error"));

            // Act
            var result = await _controller.GetMajorDetail(majorId);

            // Assert
            var badRequestResult = result as BadRequestResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);
        }
    }
}
