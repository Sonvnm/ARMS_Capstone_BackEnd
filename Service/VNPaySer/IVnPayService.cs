using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service.VnPaySer
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(HttpContext context, Guid codePayment, decimal fee, DateTime dateCreate);
        string CreatePaymentUrlAdmission(HttpContext context, Guid codePayment, decimal fee, DateTime dateCreate);
        PayFeeAdmission PaymentExecute(IQueryCollection collections);
    }
}
