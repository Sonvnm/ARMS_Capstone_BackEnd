using ARMS_API.Controllers;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;
using Service.AdmissionInformationSer;
using Service.MajorSer;
using Service.VnPaySer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Test_Controller
{
    [TestClass]
    public class VNPayControllerTests
    {
        private Mock<IVnPayService> _vnPayServiceMock;
        private Mock<IAdmissionInformationService> _admissionInfoServiceMock;
        private Mock<IMajorService> _majorServiceMock;
        private Mock<IConfiguration> _configurationMock;
        private VNPayController _controller;

        [TestInitialize]
        public void Setup()
        {
            _vnPayServiceMock = new Mock<IVnPayService>();
            _admissionInfoServiceMock = new Mock<IAdmissionInformationService>();
            _majorServiceMock = new Mock<IMajorService>();
            _configurationMock = new Mock<IConfiguration>();

            _controller = new VNPayController(
                _vnPayServiceMock.Object,
                _admissionInfoServiceMock.Object,
                _majorServiceMock.Object,
                _configurationMock.Object
            );
        }
        #region CreatePayment
        [TestMethod]
        public async Task CreatePayment_ReturnsPaymentUrl()
        {
            // Arrange
            var request = new VnPaymentRequestModel
            {
                Campus = "CampusA"
            };
            var admissionInfo = new AdmissionInformation
            {
                FeeRegister = 500m
            };
            var paymentUrl = "https://arms.com/payment";

            _admissionInfoServiceMock
                .Setup(s => s.GetAdmissionInformationByStatus("CampusA"))
                .ReturnsAsync(admissionInfo);

            _vnPayServiceMock
                .Setup(s => s.CreatePaymentUrl(It.IsAny<HttpContext>(), It.IsAny<Guid>(), 500m, It.IsAny<DateTime>()))
                .Returns(paymentUrl);

            // Act
            var result = await _controller.CreatePayment(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }


        [TestMethod]
        public async Task CreatePayment_ReturnsBadRequest_WhenRequestIsNull()
        {
            // Act
            var result = await _controller.CreatePayment(null) as BadRequestObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode);

            var response = result.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không nhận được thông tin yêu cầu!", response.Message);
        }

        [TestMethod]
        public async Task CreatePayment_ReturnsNotFound_WhenAdmissionInfoIsNull()
        {
            // Arrange
            var request = new VnPaymentRequestModel
            {
                Campus = "CampusA"
            };

            _admissionInfoServiceMock
                .Setup(s => s.GetAdmissionInformationByStatus("CampusA"))
                .ReturnsAsync((AdmissionInformation)null);

            // Act
            var result = await _controller.CreatePayment(request) as NotFoundObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);

            var response = result.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không tìm thấy đợt tuyển sinh của campus!", response.Message);

            _admissionInfoServiceMock.Verify(s => s.GetAdmissionInformationByStatus("CampusA"), Times.Once);
        }
        [TestMethod]
        public async Task CreatePayment_ThrowsException_ReturnsBadRequest()
        {
            // Arrange
            var request = new VnPaymentRequestModel
            {
                Campus = "Hanoi"
            };

            // Mocking `GetAdmissionInformationByStatus` to throw an exception
            _admissionInfoServiceMock
                .Setup(s => s.GetAdmissionInformationByStatus(It.IsAny<string>()))
                .ThrowsAsync(new Exception("Simulated exception"));

            // Act
            var result = await _controller.CreatePayment(request) as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode); // BadRequest status code

            // Validate the response message
            var response = result.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Đã xảy ra lỗi! Vui lòng thử lại sau!", response.Message);

            // Verify the mocked method was called
            _admissionInfoServiceMock.Verify(s => s.GetAdmissionInformationByStatus(It.IsAny<string>()), Times.Once);
        }
        #endregion
        #region VNPayReturn
        [TestMethod]
        public void VNPayReturn_ExceptionThrown_ReturnsBadRequest()
        {
            // Arrange
            var queryParams = new QueryCollection(new Dictionary<string, StringValues>
            {
                { "vnp_Amount", "100000" },
                { "vnp_OrderInfo", "TestOrder" }
            });

            // Mock `PaymentExecute` to throw an exception
            _vnPayServiceMock
                .Setup(s => s.PaymentExecute(It.IsAny<IQueryCollection>()))
                .Throws(new Exception("Simulated exception"));

            // Simulate HttpContext
            var context = new DefaultHttpContext();
            context.Request.Query = queryParams;
            _controller.ControllerContext.HttpContext = context;

            // Act
            var result = _controller.VNPayReturn() as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode); // BadRequest
            var response = result.Value as ResponseViewModel;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Đã xảy ra lỗi! Vui lòng thử lại sau!", response.Message);
        }

        #endregion
        #region pay-admission
        [TestMethod]
        public async Task CreatePaymentFeeAdmission_ReturnsPaymentUrl_WhenValidRequest()
        {
            // Arrange
            var request = new VnPaymentRequestModel
            {
                Campus = "Campus1",
                Major = "Major1"
            };

            var admissionInfo = new AdmissionInformation
            {
                FeeRegister = 100000
            };

            var major = new Major
            {
                Tuition = 50000
            };

            var paymentUrl = "https://paymenturl.com";
            var codePay = Guid.NewGuid();
            decimal totalFee = (decimal)(admissionInfo.FeeRegister + major.Tuition);
            DateTime paymentTime = DateTime.UtcNow;

            // Mock các dịch vụ
            _admissionInfoServiceMock
                .Setup(s => s.GetAdmissionInformationByStatus(It.IsAny<string>()))
                .ReturnsAsync(admissionInfo);

            _majorServiceMock
                .Setup(s => s.GetMajor(It.IsAny<string>()))
                .ReturnsAsync(major);

            _vnPayServiceMock
                .Setup(s => s.CreatePaymentUrl(It.IsAny<HttpContext>(), It.IsAny<Guid>(), It.IsAny<decimal>(), It.IsAny<DateTime>()))
                .Returns(paymentUrl);

            // Act
            var result = await _controller.CreatePaymentFeeAdmission(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod]
        public async Task CreatePaymentFeeAdmission_ReturnsBadRequest_WhenRequestIsNull()
        {
            // Arrange
            VnPaymentRequestModel request = null;

            // Act
            var result = await _controller.CreatePaymentFeeAdmission(request) as BadRequestObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode);
            dynamic response = result.Value;
            Assert.AreEqual("Không nhận được thông tin yêu cầu!", response.Message);
        }

        [TestMethod]
        public async Task CreatePaymentFeeAdmission_ReturnsNotFound_WhenAdmissionInfoNotFound()
        {
            // Arrange
            var request = new VnPaymentRequestModel
            {
                Campus = "Campus1",
                Major = "Major1"
            };

            _admissionInfoServiceMock
                .Setup(s => s.GetAdmissionInformationByStatus(It.IsAny<string>()))
                .ReturnsAsync((AdmissionInformation)null);

            // Act
            var result = await _controller.CreatePaymentFeeAdmission(request) as NotFoundObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);
            dynamic response = result.Value;
            Assert.AreEqual("Không tìm thấy đợt tuyển sinh của campus!", response.Message);
        }

        [TestMethod]
        public async Task CreatePaymentFeeAdmission_ReturnsNotFound_WhenMajorNotFound()
        {
            // Arrange
            var request = new VnPaymentRequestModel
            {
                Campus = "Campus1",
                Major = "Major1"
            };

            var admissionInfo = new AdmissionInformation
            {
                FeeRegister = 100000
            };

            _admissionInfoServiceMock
                .Setup(s => s.GetAdmissionInformationByStatus(It.IsAny<string>()))
                .ReturnsAsync(admissionInfo);

            _majorServiceMock
                .Setup(s => s.GetMajor(It.IsAny<string>()))
                .ReturnsAsync((Major)null);

            // Act
            var result = await _controller.CreatePaymentFeeAdmission(request) as NotFoundObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);
            dynamic response = result.Value;
            Assert.AreEqual("Không tìm thông tin ngành học!", response.Message);
        }

        [TestMethod]
        public async Task CreatePaymentFeeAdmission_ReturnsBadRequest_WhenExceptionOccurs()
        {
            // Arrange
            var request = new VnPaymentRequestModel
            {
                Campus = "Campus1",
                Major = "Major1"
            };

            // Mock để ném ngoại lệ
            _admissionInfoServiceMock
                .Setup(s => s.GetAdmissionInformationByStatus(It.IsAny<string>()))
                .ThrowsAsync(new Exception());

            // Act
            var result = await _controller.CreatePaymentFeeAdmission(request) as BadRequestObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode);
            dynamic response = result.Value;
            Assert.AreEqual("Đã xảy ra lỗi! Vui lòng thử lại sau!", response.Message);
        }
        #endregion
    }
}
