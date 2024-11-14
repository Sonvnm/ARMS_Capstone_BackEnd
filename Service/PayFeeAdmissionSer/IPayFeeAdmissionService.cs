using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.PayFeeAdmissionSer
{
    public interface IPayFeeAdmissionService
    {
        Task<List<PayFeeAdmission>> GetPayFeeAdmissions(string campusId);
        Task AddNewPayFeeAdmission(PayFeeAdmission payFeeAdmission);
    }
}
