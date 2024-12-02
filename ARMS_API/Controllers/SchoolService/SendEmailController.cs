using ARMS_API.Helper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Service.AccountSer;
using Service.EmailSer;
using Service.RequestNotificationSer;
using static System.Net.WebRequestMethods;

namespace ARMS_API.Controllers.SchoolService
{
    [Route("api/SchoolService/[controller]")]
    [ApiController]
    //[Authorize(Roles = "SchoolService")]
    public class SendEmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly IAccountService _accountService;
        private readonly IRequestNotificationService _requestNotificationService;
        private readonly EmailQueue _emailQueue;
        public SendEmailController(IEmailService emailService, IAccountService accountService, EmailQueue emailQueue,IRequestNotificationService requestNotificationService)
        {
            _emailService = emailService;
            _accountService = accountService;
            _emailQueue = emailQueue;
            _requestNotificationService = requestNotificationService;
        }
        [HttpGet("get-request-notification")]
        public async Task<IActionResult> GetRequestChangeMajor()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized("Không tìm thấy ID người dùng!");
                }
                List<RequestNotification> request = await _requestNotificationService.GetRequests(Guid.Parse(userId));
                return Ok(request);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpPost("send-notification-to-student")]
        public async Task<IActionResult> SendNotificationByEmail([FromBody] RequestSendNotification requestSendNotification)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
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
                            Subject = requestSendNotification.Subject,
                            Body = requestSendNotification.Content
                        };

                        await _emailService.SendEmailByHTMLAsync(emailRequest);
                    }
                });
                RequestNotification requestNotification = new RequestNotification()
                {
                    AccountId = Guid.Parse(userId),
                    Content = requestSendNotification.Content,
                    Subject = requestSendNotification.Subject,
                    TimeSend = DateTime.Now
                };
                _requestNotificationService.AddNewRequest(requestNotification);
                return Ok("Thông báo đã được gửi!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

    }
}
