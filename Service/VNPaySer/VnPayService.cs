using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.VnPaySer
{
    public class VnPayService : IVnPayService
    {
        private readonly IConfiguration _config;

        public VnPayService(IConfiguration config)
        {
            _config = config;
        }

        public string CreatePaymentUrl(HttpContext context, Guid codePayment, decimal fee, DateTime dateCreate)
        {
            var tick = DateTime.Now.Ticks.ToString();

            var vnpay = new VnPayLibrary();
            vnpay.AddRequestData("vnp_Version", _config["VNPay:Version"]);
            vnpay.AddRequestData("vnp_Command", _config["VNPay:Command"]);
            vnpay.AddRequestData("vnp_TmnCode", _config["VNPay:TmnCode"]);
            vnpay.AddRequestData("vnp_Amount", ((int)(fee * 100)).ToString());

            vnpay.AddRequestData("vnp_CreateDate", dateCreate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", _config["VNPay:CurrCode"]);
            vnpay.AddRequestData("vnp_IpAddr", Utils.GetIpAddress(context));
            vnpay.AddRequestData("vnp_Locale", _config["VNPay:Locale"]);

            vnpay.AddRequestData("vnp_OrderInfo", "Thanh toán hoá đơn:" + codePayment);
            vnpay.AddRequestData("vnp_OrderType", "other");
            vnpay.AddRequestData("vnp_ReturnUrl", _config["VNPay:PaymentBackReturnUrl"]);

            vnpay.AddRequestData("vnp_TxnRef", tick);

            var paymentUrl = vnpay.CreateRequestUrl(_config["VNPay:BaseUrl"], _config["VNPay:HashSecret"]);
            Console.WriteLine(_config["VNPay:HashSecret"]);
            Console.WriteLine(_config["VNPay:TmnCode"]);
            return _config["VNPay:Url"] + paymentUrl;
        }
        public string CreatePaymentUrlAdmission(HttpContext context, Guid codePayment, decimal fee, DateTime dateCreate)
        {
            var tick = DateTime.Now.Ticks.ToString();

            var vnpay = new VnPayLibrary();
            vnpay.AddRequestData("vnp_Version", _config["VNPay:Version"]);
            vnpay.AddRequestData("vnp_Command", _config["VNPay:Command"]);
            vnpay.AddRequestData("vnp_TmnCode", _config["VNPay:TmnCode"]);
            vnpay.AddRequestData("vnp_Amount", ((int)(fee * 100)).ToString());

            vnpay.AddRequestData("vnp_CreateDate", dateCreate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", _config["VNPay:CurrCode"]);
            vnpay.AddRequestData("vnp_IpAddr", Utils.GetIpAddress(context));
            vnpay.AddRequestData("vnp_Locale", _config["VNPay:Locale"]);

            vnpay.AddRequestData("vnp_OrderInfo", "Thanh toán hoá đơn:" + codePayment);
            vnpay.AddRequestData("vnp_OrderType", "other");
            vnpay.AddRequestData("vnp_ReturnUrl", _config["VNPay:PaymentBackReturnUrlAdmission"]);

            vnpay.AddRequestData("vnp_TxnRef", tick);

            var paymentUrl = vnpay.CreateRequestUrl(_config["VNPay:BaseUrl"], _config["VNPay:HashSecret"]);
            Console.WriteLine(_config["VNPay:HashSecret"]);
            Console.WriteLine(_config["VNPay:TmnCode"]);
            return _config["VNPay:Url"] + paymentUrl;
        }

        public PayFeeAdmission PaymentExecute(IQueryCollection collections)
        {
            var vnpay = new VnPayLibrary();
            foreach (var (key, value) in collections)
            {
                if (!string.IsNullOrEmpty(key) && key.StartsWith("vnp_"))
                {
                    vnpay.AddResponseData(key, value.ToString());
                }
            }

            var vnp_TxnRef = vnpay.GetResponseData("vnp_TxnRef");
            var vnp_Amount = decimal.Parse(vnpay.GetResponseData("vnp_Amount")) / 100;
            var vnp_BankCode = vnpay.GetResponseData("vnp_BankCode");
            var vnp_BankTranNo = vnpay.GetResponseData("vnp_BankTranNo");
            var vnp_CardType = vnpay.GetResponseData("vnp_CardType");
            var vnp_OrderInfo = vnpay.GetResponseData("vnp_OrderInfo");
            var vnp_OrderType = vnpay.GetResponseData("vnp_OrderType");
            var vnp_PayDate = DateTime.ParseExact(vnpay.GetResponseData("vnp_PayDate"), "yyyyMMddHHmmss", null);
            var vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");
            var vnp_TmnCode = vnpay.GetResponseData("vnp_TmnCode");
            var vnp_TransactionNo = vnpay.GetResponseData("vnp_TransactionNo");
            var vnp_TransactionStatus = vnpay.GetResponseData("vnp_TransactionStatus");
            var vnp_SecureHash = collections["vnp_SecureHash"];

            bool checkSignature = vnpay.ValidateSignature(vnp_SecureHash, _config["VNPay:HashSecret"]);
            if (!checkSignature)
            {
                return new PayFeeAdmission
                {
                    Success = false
                };
            }
            return new PayFeeAdmission
            {
                Success = true,
                TxnRef = vnp_TxnRef,
                Amount = vnp_Amount,
                BankCode = vnp_BankCode,
                BankTranNo = vnp_BankTranNo,
                CardType = vnp_CardType,
                OrderInfo = vnp_OrderInfo,
                PayDate = vnp_PayDate,
                ResponseCode = vnp_ResponseCode,
                TmnCode = vnp_TmnCode,
                TransactionNo = vnp_TransactionNo,
                TransactionStatus = vnp_TransactionStatus,
                SecureHash = vnp_SecureHash
            };
        }
    }
}
