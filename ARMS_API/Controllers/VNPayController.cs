using Microsoft.AspNetCore.Mvc;
using Service.AdmissionInformationSer;
using Service.MajorSer;

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
        public async Task<IActionResult> CreatePayment()
        {
            return Ok();
        }
        [HttpGet("vnpay_return")]
        public IActionResult VNPayReturn()
        {
            return Ok();
        }
        [HttpPost("pay-admission")]
        public async Task<IActionResult> CreatePaymentFeeAdmission()
        {
            return Ok();
        }

    }
}
