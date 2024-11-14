using Data.ArmsContext;
using Data.Models;
using Repository;
using Repository.MajorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.PayFeeAdmissionSer
{
    public class PayFeeAdmissionService : IPayFeeAdmissionService
    {
        private readonly PayFeeAdmissionRepository _payFeeAdmissionRepository;
        public PayFeeAdmissionService(ArmsDbContext context)
        {
            _payFeeAdmissionRepository = new PayFeeAdmissionRepository(context);
        }
        public Task AddNewPayFeeAdmission(PayFeeAdmission payFeeAdmission) => _payFeeAdmissionRepository.AddNewPayFeeAdmission(payFeeAdmission);

        public Task<List<PayFeeAdmission>> GetPayFeeAdmissions(string campusId)
        => _payFeeAdmissionRepository.GetPayFeeAdmissions(campusId);
    }
}
