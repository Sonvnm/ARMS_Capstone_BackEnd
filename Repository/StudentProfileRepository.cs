using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.StudentProfileRepo
{
    public class StudentProfileRepository 
    {
        private readonly ArmsDbContext _context;
        public StudentProfileRepository(ArmsDbContext context) { _context = context; }
        public async Task AddStudentProfile(StudentProfile StudentProfile)
        {
            try
            {
                await _context.StudentProfiles.AddRangeAsync(StudentProfile);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> isExistCCCDStudent(string CID)
        {
            try
            {
                var sf = await _context.StudentProfiles.FirstOrDefaultAsync(x => x.CitizenIentificationNumber.Equals(CID));
                if (sf == null) { return true; }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<StudentProfile> GetExistCCCDStudent(string CID)
        {
            try
            {
                var sf = await _context.StudentProfiles
                    .Include(x=>x.AcademicTranscripts)
                    .Include(x=>x.Campus)
                    .Include(x => x.PriorityDetail)
                    .Include(x => x.PayFeeAdmissions)
                    .Include(x => x.MajorNV1)
                    .Include(x => x.MajorNV2)
                    .Include(x => x.AdmissionTime)
                    .FirstOrDefaultAsync(x => x.CitizenIentificationNumber.Equals(CID));
                
                return sf;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> isExistEmailStudent(string email)
        {
            try
            {
                var sf = await _context.StudentProfiles.FirstOrDefaultAsync(x => x.EmailStudent.ToLower().Equals(email.ToLower()));
                if (sf == null) { return true; }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> isExistPhoneNumberStudent(string phonenumber)
        {
            try
            {
                var sf = await _context.StudentProfiles.FirstOrDefaultAsync(x => x.PhoneStudent.Equals(phonenumber));
                if (sf == null) { return true; }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<int> CountAdmissionMajor(string majorId, string CampusId)
        {
            try
            {
                var majorAdmission = await _context.StudentProfiles
                    .Where(x=>(x.Major1 == majorId 
                    || x.Major2== majorId) && x.CampusId == CampusId 
                    &&( x.TypeofStatusMajor1 == TypeofStatusForMajor.Pass || x.TypeofStatusMajor2 == TypeofStatusForMajor.Pass && (x.TypeofStatusProfile == TypeofStatus.SuccessProfileAdmission|| x.TypeofStatusProfile == TypeofStatus.ConfirmSuccessProfileAdmission || x.TypeofStatusProfile == TypeofStatus.Done)))
                    .ToListAsync();

                return majorAdmission.Count();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<StudentProfile>> GetRegisterAdmission(string CampusId)
        {
            try
            {
                var RegisterAdmission = await _context.StudentProfiles
                    .Include(x=>x.Campus)
                    .Include(x => x.AcademicTranscripts)
                    .Include(x => x.PriorityDetail)
                    .Include(x => x.PayFeeAdmissions)
                    .Include(x => x.MajorNV1)
                    .Include(x => x.MajorNV2)
                    .Where(x => x.CampusId == CampusId)
                    .OrderByDescending(x => x.PriorityDetailPriorityID)
                    .OrderBy(x => x.TimeRegister)
                    .ToListAsync();

                return RegisterAdmission;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<StudentProfile>> GetRegisterAdmission(int ATId)
        {
            try
            {
                var registerAdmissions = await _context.StudentProfiles
                    .Include(x => x.Campus)
                    .Include(x => x.AcademicTranscripts)
                    .Include(x => x.PriorityDetail)
                    .Include(x => x.PayFeeAdmissions)
                    .Include(x => x.MajorNV1)
                    .Include(x => x.MajorNV2)
                    .Where(x => x.AdmissionTimeId == ATId)
                    .ToListAsync();

                // Tính tổng điểm dựa trên từng nguyện vọng và điểm ưu tiên
                var sortedAdmissions = registerAdmissions
                    .Select(student =>
                    {
                        // Lấy điểm ưu tiên
                        var priorityScore = student.PriorityDetail?.TypeOfPriority switch
                        {
                            TypeOfPriority.UT1 => 2,
                            TypeOfPriority.UT2 => 1,
                            _ => 0 // Mặc định nếu không phải UT1 hoặc UT2
                        };

                        // Tính tổng điểm cho Nguyện vọng 1
                        var scoreNV1 = student.AcademicTranscripts
                            .Where(transcript => transcript.isMajor1) // Lọc cho Nguyện vọng 1
                            .Sum(transcript => transcript.SubjectPoint) // Tổng điểm các môn
                            + priorityScore; // Cộng điểm ưu tiên

                        // Tính tổng điểm cho Nguyện vọng 2
                        var scoreNV2 = student.AcademicTranscripts
                            .Where(transcript => !transcript.isMajor1) // Lọc cho Nguyện vọng 2
                            .Sum(transcript => transcript.SubjectPoint) // Tổng điểm các môn
                            + priorityScore; // Cộng điểm ưu tiên

                        return new
                        {
                            Student = student,
                            ScoreNV1 = scoreNV1,
                            ScoreNV2 = scoreNV2
                        };
                    })
                    .OrderByDescending(x => x.ScoreNV1) // Sắp xếp giảm dần theo điểm Nguyện vọng 1
                    .ThenByDescending(x => x.ScoreNV2) // Sắp xếp phụ giảm dần theo điểm Nguyện vọng 2
                    .ThenBy(x => x.Student.PriorityDetail.PriorityID) // Sắp xếp phụ theo độ ưu tiên
                    .ThenBy(x => x.Student.TimeRegister) // Sắp xếp phụ theo thời gian đăng ký
                    .Select(x => x.Student) // Lấy danh sách StudentProfile
                    .ToList();

                return sortedAdmissions;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public async Task<StudentProfile?> GetStudentProfileBySpIdAsync(Guid id)
        {
            var studentProfile = await _context.StudentProfiles
                .Include(x => x.Campus)
                    .Include(x => x.AcademicTranscripts)
                    .Include(x => x.PriorityDetail)
                    .Include(x => x.PayFeeAdmissions)
                    .Include(x => x.MajorNV1)
                    .Include(x => x.MajorNV2)
                    .Include(x => x.AdmissionTime)
                .FirstOrDefaultAsync(x => x.SpId == id);

            return studentProfile;
        }
        public async Task<StudentProfile?> GetStudentProfileBySpCIIdAsync(string id)
        {
            var studentProfile = await _context.StudentProfiles
                .Include(x => x.Campus)
                .Include(x => x.AcademicTranscripts)
                .Include(x => x.PriorityDetail)
                .Include(x=>x.PayFeeAdmissions)
                .Include(x => x.AdmissionTime)
                .FirstOrDefaultAsync(x => x.CitizenIentificationNumber == id);

            return studentProfile;
        }
        public async Task<StudentProfile> UpdateStudentRegister(StudentProfile StudentProfile)
        {
            try
            {
                _context.Entry<StudentProfile>(StudentProfile).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
                return StudentProfile;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
