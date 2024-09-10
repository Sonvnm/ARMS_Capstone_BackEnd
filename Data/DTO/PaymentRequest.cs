using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class PaymentRequest
    {
        public string TmnCode { get; set; }
        public string HashSecret { get; set; }
        public string Url { get; set; } 
        public string OrderId { get; set; }
        public string Amount { get; set; }
        public string OrderInfo { get; set; }
        public string RedirectUrl { get; set; }
        public string Locale { get; set; }
        public string IpAddress { get; set; }
    }
}
