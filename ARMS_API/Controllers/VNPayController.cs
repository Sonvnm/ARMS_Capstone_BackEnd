using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers
{
    public class VNPayController : Controller
    {
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
