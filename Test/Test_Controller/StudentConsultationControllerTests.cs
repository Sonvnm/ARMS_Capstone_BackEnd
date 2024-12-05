using ARMS_API.Controllers;
using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.Web.CodeGeneration;
using Moq;
using Service.StudentConsultationSer;
namespace Test.Test_Controller
{
    [TestClass]
    public class StudentConsultationControllerTests
    {
        private Mock<UserInput> _mockUserInput;  // Mock for UserInput

        [TestInitialize]
        public void Setup()
        {
            _mockUserInput = new Mock<UserInput>();
        }
        #region InputStudentConsultation
        [TestMethod]
        public void InputStudentConsultation_ShouldThrowArgumentNullException_WhenDtoIsNull()
        {
            // Arrange
            StudentConsultationDTO nullDTO = null;

            // Initialize the class under test with the mocked UserInput
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentNullException>(() =>
                validStudentConsultation.InputStudentConsultation(nullDTO));

            // Assert
            Assert.AreEqual("Không nhận được dữ liệu (Parameter 'studentConsultationDTO')", exception.Message);
        }

        [TestMethod]
        public void InputStudentConsultation_ShouldThrowArgumentException_WhenFullNameIsEmpty()
        {
            // Arrange
            var dto = new StudentConsultationDTO
            {
                FullName = "", // Empty FullName
                Email = "test@example.com",
                PhoneNumber = "1234567890",
                MajorID = "HWE",
                LinkFB = "facebook.com/test"
            };
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
               validStudentConsultation.InputStudentConsultation(dto));

            Assert.AreEqual("Không được để trống họ và tên (Parameter 'FullName')", exception.Message);
        }

        [TestMethod]
        public void InputStudentConsultation_ShouldThrowArgumentException_WhenEmailIsEmpty()
        {
            // Arrange
            var dto = new StudentConsultationDTO
            {
                FullName = "Nguyen Van A",
                Email = "", // Empty Email
                PhoneNumber = "1234567890",
                MajorID = "HWE",
                LinkFB = "facebook.com/test"
            };
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
                validStudentConsultation.InputStudentConsultation(dto));

            Assert.AreEqual("Không được để trống email (Parameter 'Email')", exception.Message);
        }

        [TestMethod]
        public void InputStudentConsultation_ShouldThrowFormatException_WhenEmailIsInvalid()
        {
            // Arrange
            var dto = new StudentConsultationDTO
            {
                FullName = "Nguyen Van A",
                Email = "invalid-email", // Invalid Email
                PhoneNumber = "1234567890",
                MajorID = "HWE",
                LinkFB = "facebook.com/test"
            };
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            // Act & Assert
            var exception = Assert.ThrowsException<FormatException>(() =>
                validStudentConsultation.InputStudentConsultation(dto));

            Assert.AreEqual("Email không hợp lệ!", exception.Message);
        }

        [TestMethod]
        public void InputStudentConsultation_ShouldThrowArgumentException_WhenPhoneNumberIsEmpty()
        {
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            // Arrange
            var dto = new StudentConsultationDTO
            {
                FullName = "Nguyen Van A",
                Email = "test@example.com",
                PhoneNumber = "", // Empty Phone Number
                MajorID = "HWE",
                LinkFB = "facebook.com/test"
            };

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
                validStudentConsultation.InputStudentConsultation(dto));

            Assert.AreEqual("Không được để trống số điện thoại (Parameter 'PhoneNumber')", exception.Message);
        }

        [TestMethod]
        public void InputStudentConsultation_ShouldThrowFormatException_WhenPhoneNumberIsInvalid()
        {
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            // Arrange
            var dto = new StudentConsultationDTO
            {
                FullName = "Nguyen Van A",
                Email = "test@example.com",
                PhoneNumber = "invalid-phone", // Invalid Phone Number
                MajorID = "HWE",
                LinkFB = "facebook.com/test"
            };

            // Act & Assert
            var exception = Assert.ThrowsException<FormatException>(() =>
                validStudentConsultation.InputStudentConsultation(dto));

            Assert.AreEqual("Số điện thoại không hợp lệ!", exception.Message);
        }

        [TestMethod]
        public void InputStudentConsultation_ShouldThrowArgumentException_WhenMajorIDIsNull()
        {
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            // Arrange
            var dto = new StudentConsultationDTO
            {
                FullName = "Nguyen Van A",
                Email = "test@example.com",
                PhoneNumber = "1234567890",
                MajorID = null, // Null MajorID
                LinkFB = "facebook.com/test"
            };

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
                validStudentConsultation.InputStudentConsultation(dto));

            Assert.AreEqual("Không được để trống ngành học (Parameter 'MajorID')", exception.Message);
        }

        [TestMethod]
        public void InputStudentConsultation_ShouldThrowArgumentException_WhenLinkFBIsEmpty()
        {
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            // Arrange
            var dto = new StudentConsultationDTO
            {
                FullName = "Nguyen Van A",
                Email = "test@example.com",
                PhoneNumber = "1234567890",
                MajorID = "HWE",
                LinkFB = "" // Empty LinkFB
            };

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
                validStudentConsultation.InputStudentConsultation(dto));

            Assert.AreEqual("Không được để trống link Facebook (Parameter 'LinkFB')", exception.Message);
        }

        [TestMethod]
        public void InputStudentConsultation_ShouldNotThrowException_WhenDtoIsValid()
        {
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            // Arrange
            var dto = new StudentConsultationDTO
            {
                FullName = "Nguyen Van A",
                Email = "test@example.com",
                PhoneNumber = "1234567890",
                MajorID = "HWE",
                LinkFB = "facebook.com/test"
            };

            // Act & Assert
            validStudentConsultation.InputStudentConsultation(dto);
        }
        #endregion
        #region AddStudentConsultation
        [TestMethod]
        public async Task AddStudentConsultation_ShouldReturnOk_WhenDataIsValid()
        {
            var mockUserInput = new Mock<UserInput>();

            var validStudentConsultation = new ValidStudentConsultation(mockUserInput.Object);

            var studentConsultationDTO = new StudentConsultationDTO
            {
                FullName = "Nguyen Van A",
                Email = "test@gmail.com",
                PhoneNumber = "1234567890",
                MajorID = "HWE",
                LinkFB = "facebook.com/test"
            };

            validStudentConsultation.InputStudentConsultation(studentConsultationDTO);

            var mockMapper = new Mock<IMapper>();
            var mockStudentConsultationService = new Mock<IStudentConsultationService>();

            var studentConsultation = new StudentConsultation
            {
                StudentConsultationId = Guid.NewGuid(),
                FullName = studentConsultationDTO.FullName,
                Email = studentConsultationDTO.Email,
                PhoneNumber = studentConsultationDTO.PhoneNumber,
                MajorID = studentConsultationDTO.MajorID,
                LinkFB = studentConsultationDTO.LinkFB,
                Status = StatusConsultation.Reception,
                DateReceive = DateTime.Now
            };

            // Mock methods
            mockMapper.Setup(m => m.Map<StudentConsultation>(It.IsAny<StudentConsultationDTO>())).Returns(studentConsultation);
            mockStudentConsultationService.Setup(s => s.AddNewStudentConsultation(It.IsAny<StudentConsultation>())).Returns(Task.CompletedTask);

            // Create the controller with mocked dependencies
            var controller = new StudentConsultationController(
                mockStudentConsultationService.Object,
                mockMapper.Object,
                validStudentConsultation,
                mockUserInput.Object
            );

            // Act
            var result = await controller.AddStudentConsultation(studentConsultationDTO);

            // Assert: Check the result
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Đăng ký thành công!", response.Message);
        }
        [TestMethod]
        public async Task AddStudentConsultation_ShouldReturnBadRequest_WhenExceptionIsThrown()
        {
            var mockUserInput = new Mock<UserInput>();


            var studentConsultationDTO = new StudentConsultationDTO
            {
                FullName = "",
                Email = "test@example.com",
                PhoneNumber = "1234567890",
                MajorID = "HWE",
                LinkFB = "facebook.com/test"
            };
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
               validStudentConsultation.InputStudentConsultation(studentConsultationDTO));

            var mockMapper = new Mock<IMapper>();
            var mockStudentConsultationService = new Mock<IStudentConsultationService>();

            var controller = new StudentConsultationController(
                mockStudentConsultationService.Object,
                mockMapper.Object,
                validStudentConsultation,
                mockUserInput.Object
            );

            var result = await controller.AddStudentConsultation(studentConsultationDTO);

            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            var response = badRequestResult.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không được để trống họ và tên (Parameter 'FullName')", response.Message);
        }


        #endregion
        #region DownloadTemplate
        [TestMethod]
        public void DownloadTemplate_ShouldReturnFile_WhenFileExists()
        {
            var mockUserInput = new Mock<UserInput>();
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            var mockMapper = new Mock<IMapper>();
            var mockStudentConsultationService = new Mock<IStudentConsultationService>();
            var controller = new StudentConsultationController(
                mockStudentConsultationService.Object,
                mockMapper.Object,
                validStudentConsultation,
                mockUserInput.Object
            );
            var rootPath = Directory.GetCurrentDirectory();
            var fileDirectory = Path.Combine(rootPath, "File");
            var filePath = Path.Combine(fileDirectory, "Đăng ký tư vấn.xlsx");

            if (!Directory.Exists(fileDirectory))
            {
                Directory.CreateDirectory(fileDirectory);
            }
            var fileBytes = new byte[] { 0, 1, 2, 3, 4, 5 };
            System.IO.File.WriteAllBytes(filePath, fileBytes);

            // Act
            var result = controller.DownloadTemplate() as FileContentResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", result.ContentType);
            Assert.AreEqual("Đăng ký tư vấn.xlsx", result.FileDownloadName);
            Assert.AreEqual(fileBytes.Length, result.FileContents.Length);

            System.IO.File.Delete(filePath);
        }
        [TestMethod]
        public void DownloadTemplate_ShouldReturnStatus500_WhenExceptionOccurs()
        {
            var mockUserInput = new Mock<UserInput>();
            var validStudentConsultation = new ValidStudentConsultation(_mockUserInput.Object);
            var mockMapper = new Mock<IMapper>();
            var mockStudentConsultationService = new Mock<IStudentConsultationService>();
            var controller = new StudentConsultationController(
                mockStudentConsultationService.Object,
                mockMapper.Object,
                validStudentConsultation,
                mockUserInput.Object
            );

            // Act
            var result = controller.DownloadTemplate() as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);
        }

        #endregion
    }
}