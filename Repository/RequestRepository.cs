using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RequestRepository
    {
        private readonly ArmsDbContext _context;
        public RequestRepository(ArmsDbContext context) { _context = context; }
        public async Task<List<Data.Models.Request>> GetRequestChangeMajors(string campusId)
        {
            try
            {
                var request = _context.Requests
                    .Include(x => x.Account)
                    .Include(x => x.MajorN)
                    .Include(x => x.MajorO)
                    .Where(x => x.CampusId.Equals(campusId) && x.isRequestChangeMajor == true)
                    .ToList();

                return request;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<Data.Models.Request>> GetRequestWithDrawal(string campusId)
        {
            try
            {
                var request = _context.Requests
                    .Include(x => x.Account)
                    .Include(x => x.MajorN)
                    .Include(x => x.MajorO)
                    .Where(x => x.CampusId.Equals(campusId) && x.isRequestChangeMajor == false)
                    .ToList();

                return request;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<Data.Models.Request>> GetRequestChangeMajorsByID(Guid Id)
        {
            try
            {
                var request = _context.Requests
                    .Include(x => x.Account)
                    .Include(x => x.MajorN)
                    .Include(x => x.MajorO)
                    .Where(x => x.AccountId== Id && x.isRequestChangeMajor==true)
                    .ToList();
                return request;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<Data.Models.Request>> GetRequestWithDrawalsByID(Guid Id)
        {
            try
            {
                var request = _context.Requests
                    .Include(x => x.Account)
                    .Include(x => x.MajorN)
                    .Include(x => x.MajorO)
                    .Where(x => x.AccountId == Id && x.isRequestChangeMajor == false)
                    .ToList();
                return request;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<Data.Models.Request> GetRequestByID(int Id)
        {
            try
            {
                var request = await _context.Requests.SingleOrDefaultAsync(x => x.RequestID == Id);
                return request;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task AddNewRequest(Data.Models.Request requestChangeMajor)
        {
            try
            {
                await _context.Requests.AddAsync(requestChangeMajor);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới không thành công");
            }
        }
        public async Task UpdateRequest(Data.Models.Request request)
        {
            try
            {
                _context.Entry<Data.Models.Request>(request).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
    }
}
