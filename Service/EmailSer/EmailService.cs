using Data.DTO;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EmailSer
{
    public class EmailService : IEmailService
    {
        private readonly EmailSetting _emailSettings;
        private readonly Timer _timer;
        private readonly EmailQueue _queue;

        public EmailService(IOptions<EmailSetting> emailSettings, EmailQueue queue)
        {
            _emailSettings = emailSettings.Value;
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));
            _queue = queue;
        }

         public async Task<ResponseViewModel> SendEmailAsync(EmailRequest emailRequest)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ARMS", _emailSettings.Email));
                message.To.Add(new MailboxAddress("", emailRequest.ToEmail));

                message.Subject = emailRequest.Subject;

                message.Body = new TextPart("plain")
                {
                    Text = emailRequest.Body
                };

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(_emailSettings.Email, _emailSettings.AppPassword);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                return new ResponseViewModel() { Status = true, Message = "Gửi mail thành công" };
            }
            catch (Exception ex)
            {
                return new ResponseViewModel() { Status = false, Message = ex.Message };
            }
        }

        public async Task<ResponseViewModel> SendEmailByHTMLAsync(EmailRequest emailRequest)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ARMS", _emailSettings.Email));
                message.To.Add(new MailboxAddress("", emailRequest.ToEmail));

                message.Subject = emailRequest.Subject;

                message.Body = new TextPart("html")
                {
                    Text = emailRequest.Body
                };
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(_emailSettings.Email, _emailSettings.AppPassword);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                return new ResponseViewModel() { Status = true, Message = "Gửi mail thành công" };
            }
            catch (Exception ex)
            {
                return new ResponseViewModel() { Status = false, Message = ex.Message };
            }
        }
        //private async void DoWork(object state)
        //{
        //    // Lấy email cần gửi từ hàng đợi và xử lý
        //    EmailRequest emailRequest = null;
        //    lock (_queue)
        //    {
        //        if (_queue.Count > 0)
        //        {
        //            emailRequest = _queue.Dequeue();
        //        }
        //    }

        //    if (emailRequest != null)
        //    {
        //        try
        //        {
        //            // Gửi email
        //            var message = new MimeMessage();
        //            message.From.Add(new MailboxAddress("ARMS", _emailSettings.Email));
        //            message.To.Add(new MailboxAddress("", emailRequest.ToEmail));
        //            message.Subject = emailRequest.Subject;
        //            message.Body = new TextPart("html")
        //            {
        //                Text = emailRequest.Body
        //            };

        //            using (var client = new SmtpClient())
        //            {
        //                await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, SecureSocketOptions.StartTls);
        //                await client.AuthenticateAsync(_emailSettings.Email, _emailSettings.AppPassword);
        //                await client.SendAsync(message);
        //                await client.DisconnectAsync(true);
        //            }

        //            Console.WriteLine("Gửi mail thành công cho: " + emailRequest.ToEmail);
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Lỗi khi gửi email: {ex.Message}");
        //        }
        //    }
        //}
        private async void DoWork(object state)
        {
            // Lấy email cần gửi từ hàng đợi và xử lý
            EmailRequest emailRequest = null;

            lock (_queue)
            {
                if (_queue.Count > 0)
                {
                    emailRequest = _queue.Dequeue();
                }
            }

            if (emailRequest != null)
            {
                try
                {
                    // Gửi email bằng phương thức đã sửa
                    var response = await SendEmailByHTMLAsync(emailRequest);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi gửi email: {ex.Message}");
                }
            }
        }

    }
}
