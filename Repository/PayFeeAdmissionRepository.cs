using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class PayFeeAdmissionRepository
    {
        private readonly ArmsDbContext _context;
        public PayFeeAdmissionRepository(ArmsDbContext context) { _context = context; }

        public async Task<List<PayFeeAdmission>> GetPayFeeAdmissions(string campusId)
        {
            try
            {
                List<PayFeeAdmission> PayFeeAdmissions = await _context.PayFeeAdmissions
                    .Include(x => x.StudentProfile)
                    .Where(x => x.StudentProfile.CampusId == campusId)
                    .ToListAsync();
                return PayFeeAdmissions;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task AddNewPayFeeAdmission(PayFeeAdmission payFeeAdmission)
        {
            try
            {
                await _context.PayFeeAdmissions.AddAsync(payFeeAdmission);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới hóa đơn không thành công");
            }
        }
    }
}
