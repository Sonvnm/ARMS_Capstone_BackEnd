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
    public class AdmissionInfomationRepository
    {
        private readonly ArmsDbContext _context;
        public AdmissionInfomationRepository(ArmsDbContext context) { _context = context; }
        public async Task<List<AdmissionInformation>> GetAdmissionInformation(string campus)
        {
            try
            {
                List<AdmissionInformation> AdmissionInformation = await _context.AdmissionInformations
                    .Where(x => x.CampusId == campus)
                    .OrderBy(x=>x.Admissions).ToListAsync();
                return AdmissionInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AdmissionInformation> GetAdmissionInformationStatusTrue(string campus)
        {
            try
            {
                AdmissionInformation AdmissionInformation = await _context.AdmissionInformations
                    .FirstOrDefaultAsync(x => 
                    //x.Status==TypeOfAdmissionInformation.Process &&
                    x.CampusId == campus);
                return AdmissionInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AdmissionInformation> GetAdmissionInformationProcess(string campus)
        {
            try
            {
                DateTime date = DateTime.Now;
                AdmissionInformation AdmissionInformation = await _context.AdmissionInformations
                    .FirstOrDefaultAsync(x => x.StartAdmission<= date && x.EndAdmission >=date && x.CampusId == campus);
                return AdmissionInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AdmissionInformation> GetAdmissionInformationById(int AdmissionInformationID)
        {
            try
            {
                AdmissionInformation AdmissionInformation = await _context.AdmissionInformations
                    .Include(x=>x.AdmissionTimes)
                    //.Include(x => x.MajorAdmissions)
                    //.ThenInclude(ma => ma.Major)
                    .FirstOrDefaultAsync(x => x.AdmissionInformationID == AdmissionInformationID);
                return AdmissionInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task UpdateAdmissionInformation(AdmissionInformation AdmissionInformation)
        {
            try
            {
                _context.Entry<AdmissionInformation>(AdmissionInformation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
        public async Task Add(AdmissionInformation AdmissionInformation)
        {
            try
            {
                await _context.AdmissionInformations.AddRangeAsync(AdmissionInformation);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới không thành công");
            }
        }
    }
}
