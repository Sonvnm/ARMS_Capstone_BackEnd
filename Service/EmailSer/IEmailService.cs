using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EmailSer
{
    public interface IEmailService
    {
        
        Task<ResponseViewModel> SendEmailAsync(EmailRequest emailRequest);
        Task<ResponseViewModel> SendEmailByHTMLAsync(EmailRequest emailRequest);

    }
}
