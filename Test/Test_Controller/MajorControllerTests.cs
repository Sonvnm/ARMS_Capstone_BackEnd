using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ARMS_API.Controllers;
using Service.MajorSer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Test.Test_Controller
{
    [TestClass]
    public class MajorControllerTests
    {
        private Mock<IMajorService> _mockMajorService;
        private Mock<IMapper> _mockMapper;
        private MajorController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockMajorService = new Mock<IMajorService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new MajorController(_mockMajorService.Object, _mockMapper.Object);
        }

        [TestMethod]
        public async Task GetMajorsVocationalSchool_ShouldReturnOk_WhenMajorsExist()
        {
            // Arrange
            var campus = "CampusA";
            var majorAdmissions = new List<MajorAdmission>
            {
                new MajorAdmission { MajorID = "1", Status=true, AdmissionTimeId=1},
            };

                var majorDTOs = new List<MajorDTO>
            {
                new MajorDTO { MajorID = "1", MajorName = "Computer Science" }
            };

            _mockMajorService.Setup(s => s.GetMajorsIsVocationalSchool(campus)).ReturnsAsync(majorAdmissions);
            _mockMapper.Setup(m => m.Map<List<MajorDTO>>(majorAdmissions)).Returns(majorDTOs);

            // Act
            var result = await _controller.GetMajorsVocationalSchool(campus);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var returnValue = okResult.Value as List<MajorDTO>;
            Assert.IsNotNull(returnValue);
            Assert.AreEqual(1, returnValue.Count);
            Assert.AreEqual("Computer Science", returnValue[0].MajorName);
        }

        [TestMethod]
        public async Task GetMajorsVocationalSchool_ShouldReturnBadRequest_WhenNoMajorsFound()
        {
            // Arrange
            var campus = "CampusA";
            _mockMajorService.Setup(s => s.GetMajorsIsVocationalSchool(campus)).ReturnsAsync((List<MajorAdmission>)null);

            // Act
            var result = await _controller.GetMajorsVocationalSchool(campus);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không có ngành trung cấp nào đang tuyển!", response.Message);
        }

        [TestMethod]
        public async Task GetMajorsVocationalSchool_ShouldReturnBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var campus = "CampusA";
            _mockMajorService.Setup(s => s.GetMajorsIsVocationalSchool(campus)).ThrowsAsync(new System.Exception());

            // Act
            var result = await _controller.GetMajorsVocationalSchool(campus);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Đã xảy ra lỗi! Vui lòng thử lại sau!", response.Message);
        }

        [TestMethod]
        public async Task GetMajorDetail_ShouldReturnNotFound_WhenMajorDoesNotExist()
        {
            // Arrange
            var majorId = "InvalidMajorId";
            _mockMajorService.Setup(s => s.GetMajorDetail(majorId)).ReturnsAsync((MajorAdmission)null);

            // Act
            var result = await _controller.GetMajorDetail(majorId);

            // Assert
            var notFoundResult = result as NotFoundObjectResult;
            Assert.IsNotNull(notFoundResult);
            var response = notFoundResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không tìm thấy ngành học!", response.Message);
        }

        [TestMethod]
        public async Task GetMajorDetail_ShouldReturnOk_WhenMajorExists()
        {
            // Arrange
            var majorId = "1";
            var majorAdmission = new MajorAdmission { MajorID = "1", Status = true, AdmissionTimeId = 1 };
            var majorDTO = new MajorDTO { MajorID = "1", MajorName = "Computer Science" };
            _mockMajorService.Setup(s => s.GetMajorDetail(majorId)).ReturnsAsync(majorAdmission);
            _mockMapper.Setup(m => m.Map<MajorDTO>(majorAdmission)).Returns(majorDTO);

            // Act
            var result = await _controller.GetMajorDetail(majorId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var returnValue = okResult.Value as MajorDTO;
            Assert.IsNotNull(returnValue);
            Assert.AreEqual("Computer Science", returnValue.MajorName);
        }
    }

}