using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.MajorRepo
{
    public class MajorRepository 
    {
        private readonly ArmsDbContext _context;
        public MajorRepository(ArmsDbContext context) { _context = context; }

        public async Task<List<Major>> GetMajors(string campusId)
        {
            try
            {
                List<Major> majors = await _context.Majors
                    .Where(x => x.CampusId.Equals(campusId) && x.Status==true)
                    .ToListAsync();
                return majors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<List<Major>> GetMajors_Manage(string campusId)
        {
            try
            {
                List<Major> majors = await _context.Majors
                    .Where(x => x.CampusId.Equals(campusId))
                    .ToListAsync();
                return majors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<Major> GetMajorDetail(string MajorID)
        {
            try
            {
                var major = await _context.Majors
                    .Include(x => x.TypeAdmissions)
                     .Include(x => x.Subjects.OrderBy(s => s.SemesterNumber))
                     .SingleOrDefaultAsync(x => x.MajorID.Equals(MajorID));
                if (major == null)
                {
                    throw new KeyNotFoundException($"Major with ID {MajorID} not found.");
                }
                return major;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task AddNewMajor(Major major)
        {
            try
            {
                await _context.Majors.AddAsync(major);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới không thành công");
            }
        }
        public async Task UpdateMajor(Major major)
        {
            try
            {
                _context.Entry<Major>(major).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
    }
}
