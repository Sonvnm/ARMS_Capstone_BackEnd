using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AdmissionTimeRepository
    {
        private readonly ArmsDbContext _context;
        public AdmissionTimeRepository(ArmsDbContext context) { _context = context; }

        public async Task<List<AdmissionTime>> GetAdmissionTimes(string CampusId)
        {
            try
            {

                List<AdmissionTime> AdmissionTimes = await _context.AdmissionTimes
                    .Where(x => x.AdmissionInformation.CampusId==CampusId).ToListAsync();
                return AdmissionTimes;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<AdmissionTime>> GetAdmissionTimes(int AdmissionInformationID)
        {
            try
            {
                List<AdmissionTime> AdmissionTime = await _context.AdmissionTimes
                    .Where(x => x.AdmissionInformationID == AdmissionInformationID).ToListAsync();
                return AdmissionTime;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AdmissionTime> GetAdmissionTime(int AdmissionTimeId)
        {
            try
            {
                AdmissionTime AdmissionTime = await _context.AdmissionTimes
                    .SingleOrDefaultAsync(x => x.AdmissionTimeId == AdmissionTimeId);
                return AdmissionTime;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task AddAdmissionTime(AdmissionTime AdmissionTime)
        {
            try
            {
                 _context.AdmissionTimes.AddRangeAsync(AdmissionTime);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới không thành công");
            }
        }
        public async Task UpdateAdmissionTime(AdmissionTime AdmissionTime)
        {
            try
            {
                _context.Entry<AdmissionTime>(AdmissionTime).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
    }
}
