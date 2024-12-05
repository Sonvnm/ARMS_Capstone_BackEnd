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
using Service.MajorSer;

namespace Test.SchoolService
{
    [TestClass]
    public class MajorControllerTests
    {
        private Mock<IMajorService> _mockMajorService;
        private Mock<IMapper> _mockMapper;
        private Mock<UserInput> _mockUserInput;
        private MajorController _controller;

        [TestInitialize]
        public void Setup()
        {
            // Arrange: Set up the mocks and the controller
            _mockMajorService = new Mock<IMajorService>();
            _mockMapper = new Mock<IMapper>();
            _mockUserInput = new Mock<UserInput>();
            _controller = new MajorController(_mockMajorService.Object, _mockMapper.Object, _mockUserInput.Object);
        }

        // Test for the GetMajors method
        [TestMethod]
        public async Task GetMajors_ReturnsOk_WithFilteredMajors()
        {
            // Arrange
            var campusId = "Campus1";
            var search = "Engineering";
            var currentPage = 1;
            var college = true;

            var mockMajors = new List<MajorAdmission>
            {
                new MajorAdmission { MajorID = "1", Major = new Major { MajorName = "Engineering", MajorCode = "ENG", isVocationalSchool = true }, Status = true },
                new MajorAdmission { MajorID = "2", Major = new Major { MajorName = "Medical", MajorCode = "MED", isVocationalSchool = false }, Status = true }
            };

            var mockResponse = new ResponeModel<MajorDTO>
            {
                CurrentPage = currentPage,
                Search = search,
                CampusId = campusId
            };

            _mockMajorService.Setup(x => x.GetMajorsManage(It.IsAny<string>())).ReturnsAsync(mockMajors);

            // Act
            var result = await _controller.GetMajors(campusId, college, search, currentPage);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var responseModel = okResult.Value as ResponeModel<MajorDTO>;
            Assert.IsNotNull(responseModel);
        }

        [TestMethod]
        public async Task GetMajorDetail_ReturnsOk_WithMajorDetails()
        {
            // Arrange
            var majorId = "1";
            var mockMajor = new MajorAdmission
            {
                MajorID = majorId,
                Major = new Major { MajorName = "Engineering", MajorCode = "ENG", isVocationalSchool = true },
                Status = true
            };

            var mockMappedMajorDTO = new MajorDTO { MajorName = "Engineering", MajorCode = "ENG" };

            _mockMajorService.Setup(x => x.GetMajorDetail(It.IsAny<string>())).ReturnsAsync(mockMajor);
            _mockMapper.Setup(x => x.Map<MajorDTO>(It.IsAny<MajorAdmission>())).Returns(mockMappedMajorDTO);

            // Act
            var result = await _controller.GetMajorDetail(majorId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var majorDTO = okResult.Value as MajorDTO;
            Assert.IsNotNull(majorDTO);
            Assert.AreEqual("Engineering", majorDTO.MajorName);
            Assert.AreEqual("ENG", majorDTO.MajorCode);
        }

        [TestMethod]
        public async Task GetMajors_ReturnsBadRequest_OnException()
        {
            // Arrange
            _mockMajorService.Setup(x => x.GetMajorsManage(It.IsAny<string>())).ThrowsAsync(new Exception("Database error"));

            // Act
            var result = await _controller.GetMajors("Campus1", null, "Engineering", 1);

            // Assert
            var badRequestResult = result as BadRequestResult;
            Assert.IsNotNull(badRequestResult);
        }

        [TestMethod]
        public async Task GetMajorDetail_ReturnsBadRequest_OnException()
        {
            // Arrange
            _mockMajorService.Setup(x => x.GetMajorDetail(It.IsAny<string>())).ThrowsAsync(new Exception("Database error"));

            // Act
            var result = await _controller.GetMajorDetail("1");

            // Assert
            var badRequestResult = result as BadRequestResult;
            Assert.IsNotNull(badRequestResult);
        }
    }
}
