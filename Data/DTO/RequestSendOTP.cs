using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class RequestSendOTP
    {
        public string? CitizenIentificationNumber { get; set; }
    }
    public class RequestSendNotification
    {
        public string CampusId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
