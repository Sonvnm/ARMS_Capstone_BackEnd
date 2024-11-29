using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.AspNetCore.Http;

namespace Service.VNPaySer
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(HttpContext context, Guid codePayment, decimal fee, DateTime dateCreate);
        string CreatePaymentUrlAdmission(HttpContext context, Guid codePayment, decimal fee, DateTime dateCreate);
        PayFeeAdmission PaymentExecute(IQueryCollection collections);
    }
}
