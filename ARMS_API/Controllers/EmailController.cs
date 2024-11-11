
using ARMS_API.Helper;
using Data.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Service.EmailSer;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // đây là code test email
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly IMemoryCache _cache;
        private readonly TimeSpan _otpLifetime = TimeSpan.FromMinutes(5);
        private readonly TokenHealper _tokenHealper;
        public EmailController(IEmailService emailService, IMemoryCache cache, TokenHealper tokenHealper)
        {
            _emailService = emailService;
            _cache = cache;
            _tokenHealper= tokenHealper;
        }

        [HttpPost("send-OTP")]
        public async Task<IActionResult> SendOTPByEmail([FromBody] EmailRequest emailRequest)
        {
            if (emailRequest == null || string.IsNullOrEmpty(emailRequest.ToEmail))
            {
                return BadRequest("Invalid email request.");
            }
            var otp = new Random().Next(100000, 999999).ToString();
            emailRequest.Subject = "Send OTP";
            emailRequest.Body = $"OTP của bạn là: {otp}";
            _cache.Set(emailRequest.ToEmail, otp, _otpLifetime);
            await _emailService.SendEmailAsync(emailRequest);
            return Ok("Gửi email thành công!");
        }
        [HttpPost("verify-OTP")]
        public async Task<ActionResult<string>> VerifyOtpAsync(string email, string otp)
        {
            if (_cache.TryGetValue(email, out string storedOtp) && storedOtp == otp)
            {
                _cache.Remove(email);

                // Tạo token sau khi OTP hợp lệ
                var token = _tokenHealper.GenerateAccessToken(email);

                // Trả về token cho người dùng
                return Ok(new { Token = token });
            }

            return Unauthorized("OTP không hợp lệ.");
        }

    }
}
