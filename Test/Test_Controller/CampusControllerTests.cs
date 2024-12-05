using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ARMS_API.Controllers;
using Service.CampusSer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARMS_API.Tests
{
    [TestClass]
    public class CampusControllerTests
    {
        private Mock<ICampusService> _campusServiceMock;
        private Mock<IMapper> _mapperMock;
        private CampusController _controller;

        public CampusControllerTests()
        {
            _campusServiceMock = new Mock<ICampusService>();
            _mapperMock = new Mock<IMapper>();
            _controller = new CampusController(_campusServiceMock.Object, _mapperMock.Object);
        }

        [TestMethod]
        public async Task CountCampus_ReturnsOkResult_WithCampusCount()
        {
            // Arrange
            _campusServiceMock.Setup(service => service.CountCampus()).ReturnsAsync(5);

            // Act
            var result = await _controller.CountCampus();

            // Assert
            var okResult = result as OkObjectResult;

            Assert.IsNotNull(okResult, "Expected OkObjectResult, but got a different result");

            var returnValue = (int)okResult.Value;

            Assert.AreEqual(5, returnValue);
        }

        [TestMethod]
        public async Task GetCampuses_ReturnsOkResult_WithMappedCampusDTOs()
        {
            // Arrange
            var campusList = new List<Campus>
            {
                new Campus { CampusId = "1", CampusName = "Campus A" },
                new Campus { CampusId = "2", CampusName = "Campus B" }
            };

            var campusDTOList = new List<CampusDTO>
            {
                new CampusDTO { CampusId = "1", CampusName = "Campus A" },
                new CampusDTO { CampusId = "2", CampusName = "Campus B" }
            };

            _campusServiceMock.Setup(service => service.GetCampuses()).ReturnsAsync(campusList);

            _mapperMock.Setup(mapper => mapper.Map<List<CampusDTO>>(campusList)).Returns(campusDTOList);

            // Act
            var result = await _controller.GetCampuses();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult, "Expected OkObjectResult, but got a different result");
            var returnValue = (List<CampusDTO>)okResult.Value;
            Assert.AreEqual(2, returnValue.Count);
            Assert.AreEqual("Campus A", returnValue[0].CampusName);
            Assert.AreEqual("Campus B", returnValue[1].CampusName);
        }

        [TestMethod]
        public async Task GetCampus_ReturnsOkResult_WithMappedCampusDTO()
        {
            // Arrange
            var campus = new Campus { CampusId = "1", CampusName = "Campus A" };
            var campusDTO = new CampusDTO { CampusId = "1", CampusName = "Campus A" };

            _campusServiceMock.Setup(service => service.GetCampuses()).ReturnsAsync(new List<Campus> { campus });
            _mapperMock.Setup(mapper => mapper.Map<CampusDTO>(campus)).Returns(campusDTO);

            // Act
            var result = await _controller.GetCampuses("1");

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult, "Expected OkObjectResult, but got a different result");
            var returnValue = (CampusDTO)okResult.Value;
            Assert.AreEqual("Campus A", returnValue.CampusName);
        }

        [TestMethod]
        public async Task GetSliders_ReturnsOkResult_WithMappedSliderDTOs()
        {
            // Arrange
            var sliders = new List<Slider>
            {
                new Slider { SliderId = 1, Img = "url1" },
                new Slider { SliderId = 2, Img = "url2" }
            };

            var sliderDTOs = new List<SliderDTO>
            {
                new SliderDTO { BannerId = 1, Img = "url1" },
                new SliderDTO { BannerId = 2, Img = "url2" }
            };

            _campusServiceMock.Setup(service => service.GetSliders("1")).ReturnsAsync(sliders);
            _mapperMock.Setup(mapper => mapper.Map<List<SliderDTO>>(sliders)).Returns(sliderDTOs);

            // Act
            var result = await _controller.GetSliders("1");

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult, "Expected OkObjectResult, but got a different result");
            var returnValue = (List<SliderDTO>)okResult.Value;
            Assert.AreEqual(2, returnValue.Count);
            Assert.AreEqual("url1", returnValue[0].Img);
        }

        [TestMethod]
        public async Task GetHistory_ReturnsOkResult_WithHistoryData()
        {
            // Arrange
            var campus = new Campus { CampusId = "1", History = "Campus History Data" };
            _campusServiceMock.Setup(service => service.GetCampus("1")).ReturnsAsync(campus);

            // Act
            var result = await _controller.GetHistory("1");

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult, "Expected OkObjectResult, but got a different result");
            var returnValue = (string)okResult.Value;
            Assert.AreEqual("Campus History Data", returnValue);
        }

        [TestMethod]
        public async Task GetAchievements_ReturnsOkResult_WithAchievementsData()
        {
            // Arrange
            var campus = new Campus { CampusId = "1", Achievements = "Campus Achievements Data" };
            _campusServiceMock.Setup(service => service.GetCampus("1")).ReturnsAsync(campus);

            // Act
            var result = await _controller.GetAchievements("1");

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult, "Expected OkObjectResult, but got a different result");
            var returnValue = (string)okResult.Value;
            Assert.AreEqual("Campus Achievements Data", returnValue);
        }

        [TestMethod]
        public async Task GetWhyChooseUs_ReturnsOkResult_WithWhyChooseUsData()
        {
            // Arrange
            var campus = new Campus { CampusId = "1", WhyChooseUs = "Reasons to choose campus" };
            _campusServiceMock.Setup(service => service.GetCampus("1")).ReturnsAsync(campus);

            // Act
            var result = await _controller.GetWhyChooseUs("1");

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult, "Expected OkObjectResult, but got a different result");
            var returnValue = (string)okResult.Value;
            Assert.AreEqual("Reasons to choose campus", returnValue);
        }

        [TestMethod]
        public async Task GetTrainingMotto_ReturnsOkResult_WithTrainingMottoData()
        {
            // Arrange
            var campus = new Campus { CampusId = "1", TrainingMotto = "Campus Training Motto" };
            _campusServiceMock.Setup(service => service.GetCampus("1")).ReturnsAsync(campus);

            // Act
            var result = await _controller.GetTrainingMotto("1");

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult, "Expected OkObjectResult, but got a different result");
            var returnValue = (string)okResult.Value;
            Assert.AreEqual("Campus Training Motto", returnValue);
        }

        [TestMethod]
        public async Task GetXXX_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            _campusServiceMock.Setup(service => service.GetCampus("1")).ThrowsAsync(new System.Exception("An error occurred"));

            // Act
            var result = await _controller.GetCampuses("1");

            // Assert
            var BadRequestObjectResult = result as BadRequestObjectResult;
            Assert.IsNotNull(BadRequestObjectResult, "Expected BadRequestObjectResult, but got a different result");
            var returnValue = (ResponseViewModel)BadRequestObjectResult.Value;
            Assert.IsFalse(returnValue.Status);
            Assert.AreEqual("Đã xảy ra lỗi! Vui lòng thử lại sau!", returnValue.Message);
        }
    }
}
