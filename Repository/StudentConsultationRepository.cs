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
    public class StudentConsultationRepository
    {
        private readonly ArmsDbContext _context;
        public StudentConsultationRepository(ArmsDbContext context) { _context = context; }
        public async Task AddNewStudentConsultation(StudentConsultation studentConsultation)
        {
            try
            {
                studentConsultation.Campus = _context.Campuses.FirstOrDefault(x=>x.CampusId==studentConsultation.CampusId);
                studentConsultation.Major = _context.Majors.FirstOrDefault(x => x.MajorID == studentConsultation.MajorID);
                await _context.StudentConsultations.AddAsync(studentConsultation);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Đăng ký không thành công");
            }
        }
        public async Task<List<StudentConsultation>> GetListStudentConsultation(string campusId)
        {
            try
            {
                var studentConsultations = _context.StudentConsultations.
                    OrderByDescending(x=>x.DateReceive)
                    .Include(x=>x.Major)
                    .Where(x => x.CampusId.Equals(campusId))
                    .ToList();
                return studentConsultations;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task UpdateStudentConsultation(StudentConsultation StudentConsultation) 
        {
            try
            {
                 _context.Entry<StudentConsultation>(StudentConsultation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
