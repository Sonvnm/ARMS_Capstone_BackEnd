using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
                    .Where(x => x.CampusId.Equals(campusId) )
                    .OrderBy(x => x.isVocationalSchool)
                    .ToListAsync();
                return majors;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<Major> GetMajor(string MajorID)
        {
            try
            {
                Major major = await _context.Majors
                    .Include(x => x.Subjects)
                    .SingleOrDefaultAsync(x => x.MajorID.Equals(MajorID));
                return major;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<List<MajorAdmission>> GetMajorAdmissions(string campusId)
        {
            try
            {
                var AI = await _context.AdmissionInformations.FirstOrDefaultAsync(x=>x.Status== TypeOfAdmissionInformation.Process && x.CampusId==campusId);
                List<MajorAdmission> majors = await _context.MajorAdmissions
                    .Include(x=>x.Major)
                    .Include(x => x.AdmissionInformation)
                    .Include(x => x.TypeAdmissions)
                    .OrderBy(x => x.Major.isVocationalSchool)
                    .Where(x => x.AdmissionInformationID == AI.AdmissionInformationID).ToListAsync();
                return majors;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        // cái này sẽ bỏ
        public async Task<List<Major>> GetMajors_Manage(string campusId)
        {
            try
            {
                List<Major> majors = await _context.Majors
                    .Where(x => x.CampusId.Equals(campusId))
                    .OrderBy(x => x.isVocationalSchool)
                    .ToListAsync();
                return majors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<MajorAdmission> GetMajorDetail(string MajorID, int AdmissionInformationID)
        {

            try
            {
                MajorAdmission major = await _context.MajorAdmissions
                   .Include(x => x.Major)
                   .Include(x=> x.Major.Subjects.OrderBy(s => s.SemesterNumber))
                    .Include(x => x.TypeAdmissions)
                   .Include(x => x.AdmissionInformation)
                   .SingleOrDefaultAsync(x => x.AdmissionInformationID == AdmissionInformationID && x.MajorID == MajorID);
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
        public async Task<MajorAdmission> GetMajorDetail(string MajorID, string campusId)
        {

            try
            {
                var AI = await _context.AdmissionInformations.FirstOrDefaultAsync(x => x.Status == TypeOfAdmissionInformation.Process && x.CampusId == campusId);
                MajorAdmission major = await _context.MajorAdmissions
                   .Include(x => x.Major)
                   .Include(x => x.Major.Subjects.OrderBy(s => s.SemesterNumber))
                    .Include(x => x.TypeAdmissions)
                   .Include(x => x.AdmissionInformation)
                   .SingleOrDefaultAsync(x => x.AdmissionInformationID == AI.AdmissionInformationID && x.MajorID == MajorID);
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
                var existingMajor = await _context.Majors
                                           .Include(m => m.Subjects)  // Nạp Subjects liên quan
                                           .FirstOrDefaultAsync(m => m.MajorID == major.MajorID);

                if (existingMajor != null)
                {
                    // Cập nhật các thuộc tính của Major
                    existingMajor.MajorCode = major.MajorCode;
                    existingMajor.MajorName = major.MajorName;
                    existingMajor.Description = major.Description;
                    existingMajor.TimeStudy = major.TimeStudy;
                    existingMajor.isVocationalSchool = major.isVocationalSchool;
                    existingMajor.Tuition = major.Tuition;

                    // Cập nhật Subjects nếu có
                    if (major.Subjects != null)
                    {
                        // Duyệt qua các Subject mới gửi đến
                        foreach (var subject in major.Subjects)
                        {
                            var existingSubject = existingMajor.Subjects
                                                               .FirstOrDefault(s => s.SubjectCode == subject.SubjectCode);

                            if (existingSubject != null)
                            {
                                // Cập nhật các thông tin của Subject
                                existingSubject.SubjectCode = subject.SubjectCode;
                                existingSubject.SubjectName = subject.SubjectName;
                                existingSubject.SemesterNumber = subject.SemesterNumber;
                                existingSubject.NumberOfCredits = subject.NumberOfCredits;
                                existingSubject.Note = subject.Note;
                                existingSubject.NumberOfCredits = (int)(subject?.NumberOfCredits);
                            }
                            else
                            {
                                // Thêm Subject mới nếu không tìm thấy
                                existingMajor.Subjects.Add(subject);
                            }
                        }

                        // Xóa các Subject cũ không còn trong danh sách Subjects
                        var subjectIdsToRemove = existingMajor.Subjects
                                                             .Where(s => !major.Subjects.Any(ms => ms.SubjectCode == s.SubjectCode))
                                                             .Select(s => s.SubjectCode)
                                                             .ToList();

                        foreach (var subjectId in subjectIdsToRemove)
                        {
                            var subjectToRemove = existingMajor.Subjects
                                                               .FirstOrDefault(s => s.SubjectCode == subjectId);
                            if (subjectToRemove != null)
                            {
                                existingMajor.Subjects.Remove(subjectToRemove);
                            }
                        }
                    }

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Không tìm thấy ngành học");
                }
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
        public async Task UpdateMajorAdmission(MajorAdmission major)
        {
            try
            {
                _context.Entry<MajorAdmission>(major).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
    }
}
