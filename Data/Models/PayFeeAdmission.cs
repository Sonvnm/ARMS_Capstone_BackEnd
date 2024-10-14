using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class PayFeeAdmission
    {
        public Guid Id { get; set; }
        public string TxnRef { get; set; }
        public decimal Amount { get; set; }
        public string BankCode { get; set; }
        public string BankTranNo { get; set; }
        public string CardType { get; set; }
        public string OrderInfo { get; set; }
        public DateTime PayDate { get; set; }
        public string ResponseCode { get; set; }
        public string TmnCode { get; set; }
        public string TransactionNo { get; set; }
        public string TransactionStatus { get; set; }
        public string SecureHash { get; set; }
        public string? OrderType { get; set; }
        public bool? isFeeRegister { get; set; }
        public bool? Success { get; set; }
        public Guid SpId { get; set; }
        public virtual StudentProfile? StudentProfile { get; set; }
    }
}
