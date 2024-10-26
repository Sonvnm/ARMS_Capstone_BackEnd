using ARMS_API.Helper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Service.AccountSer;
using Service.EmailSer;
using static System.Net.WebRequestMethods;

namespace ARMS_API.Controllers.SchoolService
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendEmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly IAccountService _accountService;
        private readonly EmailQueue _emailQueue;
        public SendEmailController(IEmailService emailService, IAccountService accountService, EmailQueue emailQueue)
        {
            _emailService = emailService;
            _accountService = accountService;
            _emailQueue = emailQueue;
        }

        [HttpPost("send-notification-to-student")]
        public async Task<IActionResult> SendNotificationByEmail([FromBody] RequestSendNotification requestSendNotification)
        {
            try
            {
                if (requestSendNotification == null || string.IsNullOrEmpty(requestSendNotification.Content))
                {
                    return BadRequest("Nội dung thông báo không được để trống!");
                }

                List<Account> accounts = await _accountService.GetAccountStudent(requestSendNotification.CampusId);

                Task.Run(async () =>
                {
                    foreach (var item in accounts)
                    {
                        var emailRequest = new EmailRequest
                        {
                            ToEmail = item.Email,
                            Subject = "Notification of ARMS",
                            Body = requestSendNotification.Content
                        };

                        await _emailService.SendEmailAsync(emailRequest);
                    }
                });

                return Ok("Thông báo đã được gửi!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

    }
}
