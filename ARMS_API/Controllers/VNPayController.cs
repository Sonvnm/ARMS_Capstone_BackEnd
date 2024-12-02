using Data.DTO;
using Data.Models;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionInformationSer;
using Service.MajorSer;
using Service.VNPaySer;

namespace ARMS_API.Controllers
{
    public class VNPayController : Controller
    {
        private readonly IVnPayService _vnPayService;
        private readonly IMajorService _majorService;
        private readonly IAdmissionInformationService _admissionInformationService;
        private readonly IConfiguration _configuration;
        public VNPayController(IVnPayService vnPayService, IAdmissionInformationService admissionInformationService, IMajorService majorService, IConfiguration configuration)
        {
            _vnPayService = vnPayService;
            _admissionInformationService = admissionInformationService;
            _majorService = majorService;
            _configuration = configuration;
        }
        [HttpPost("pay-register-admission")]
        public async Task<IActionResult> CreatePayment([FromBody] VnPaymentRequestModel request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không nhận được thông tin yêu cầu!"
                    });
                }
                AdmissionInformation admissionInfo = await _admissionInformationService.GetAdmissionInformationByStatus(request.Campus);
                if (admissionInfo == null)
                {
                    return NotFound(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không tìm thấy đợt tuyển sinh của campus!"
                    });
                }
                Guid paymentCode = Guid.NewGuid();
                decimal fee = admissionInfo.FeeRegister;
                DateTime timecreate = DateTime.UtcNow;

                var paymentUrl = _vnPayService.CreatePaymentUrl(HttpContext, paymentCode, fee, timecreate);

                return Ok(new { PaymentUrl = paymentUrl });
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }

        }
        [HttpGet("vnpay_return")]
        public IActionResult VNPayReturn()
        {
            try
            {
                var queryParams = Request.Query;
                var checkResponse = _vnPayService.PaymentExecute(queryParams);
                var queryString = new StringBuilder();
                foreach (var param in queryParams)
                {
                    var encodedValue = Uri.EscapeDataString(param.Value);
                    queryString.Append($"{param.Key}={encodedValue}&");
                }
                queryString.Append(checkResponse.Success == true ? "status=success" : "status=fail");
                string returnUrl = _configuration.GetValue<string>("VNPaySettings:ReturnUrl");
                return Redirect($"{returnUrl}?{queryString}");
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
        [HttpPost("pay-admission")]
        public async Task<IActionResult> CreatePaymentFeeAdmission([FromBody] VnPaymentRequestModel request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không nhận được thông tin yêu cầu!"
                    });
                }

                Guid codePay = Guid.NewGuid();

                AdmissionInformation admissionInfo = await _admissionInformationService.GetAdmissionInformationByStatus(request.Campus);
                if (admissionInfo == null)
                {
                    return NotFound(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không tìm thấy đợt tuyển sinh của campus!"
                    });
                }

                decimal totalFee = admissionInfo.FeeRegister;

                Major major = await _majorService.GetMajor(request.Major);
                if (major == null)
                {
                    return NotFound(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không tìm thông tin ngành học!"
                    });
                }

                totalFee += (decimal)major.Tuition;

                DateTime paymentTime = DateTime.UtcNow;

                var paymentUrl = _vnPayService.CreatePaymentUrl(HttpContext, codePay, totalFee, paymentTime);

                return Ok(new { PaymentUrl = paymentUrl });
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }


    }
}
