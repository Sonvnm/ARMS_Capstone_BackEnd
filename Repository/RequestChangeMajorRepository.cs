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
    public class RequestChangeMajorRepository
    {
        private readonly ArmsDbContext _context;
        public RequestChangeMajorRepository(ArmsDbContext context) { _context = context; }
        public async Task<List<RequestChangeMajor>> GetRequestChangeMajors(string campusId)
        {
            try
            {
                var studentConsultations = _context.RequestChangeMajors
                    .Include(x => x.Account)
                    .ThenInclude(x=>x.StudentProfile)
                    .Where(x => x.CampusId.Equals(campusId))
                    .ToList();
                return studentConsultations;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<RequestChangeMajor>> GetRequestChangeMajorsByID(Guid Id)
        {
            try
            {
                var studentConsultations = _context.RequestChangeMajors
                    .Include(x => x.Account)
                    .ThenInclude(x => x.StudentProfile)
                    .Include(x => x.Major)
                    .Where(x => x.AccountId== Id)
                    .ToList();
                return studentConsultations;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
