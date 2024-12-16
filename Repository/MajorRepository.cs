using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
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
                DateTime date = DateTime.Now;
                var AT = await _context.AdmissionTimes.FirstOrDefaultAsync(x => x.StartRegister <= date && x.EndRegister >= date);
                List<MajorAdmission> majors =
                await _context.MajorAdmissions
                .Include(x => x.Major)
                .Include(x => x.AdmissionTime)
                    .ThenInclude(x => x.AdmissionInformation)
                .Include(x => x.TypeAdmissions)
                .OrderBy(x => x.Major.isVocationalSchool)
                .Where(x => x.AdmissionTimeId == AT.AdmissionTimeId && x.AdmissionTime.AdmissionInformation.CampusId == campusId).ToListAsync();
                return majors;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<List<MajorAdmission>> GetMajorAdmissionsByATId(int ATId)
        {
            try
            {
                List<MajorAdmission> majors =
                await _context.MajorAdmissions
                .Include(x => x.Major)
                .Include(x => x.TypeAdmissions)
                .OrderBy(x => x.Major.isVocationalSchool)
                .Where(x => x.AdmissionTimeId == ATId).ToListAsync();
                return majors;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<List<object>> GetMajorAdmissionsAndRegisterByATId(int ATId)
        {
            try
            {
                List<MajorAdmission> majors =
                await _context.MajorAdmissions
                .Include(x => x.Major)
                .Include(x => x.TypeAdmissions)
                .OrderBy(x => x.Major.isVocationalSchool)
                .Where(x => x.AdmissionTimeId == ATId).ToListAsync();
                var majorWithRegisterCount = new List<object>();
                foreach (var major in majors)
                {
                    var registerCount = await _context.StudentProfiles
                        .Where(r => r.Major == major.MajorID && r.AdmissionTimeId == ATId)
                        .CountAsync();
                    var registerCountPass = await _context.StudentProfiles
                        .Where(r => r.Major == major.MajorID
                                    && r.AdmissionTimeId == ATId
                                    && r.TypeofStatusProfile == TypeofStatus.SuccessProfileAdmission
                                    && r.Major == major.MajorID
                                    && r.TypeofStatusMajor == TypeofStatusForMajor.Pass)
                        .CountAsync();

                    majorWithRegisterCount.Add(new
                    {
                        MajorId = major.MajorID,
                        MajorName = major.Major?.MajorName,
                        RegisteredCount = registerCount,
                        Target = major.Target,
                        RegisterCountPass = registerCountPass
                    });
                }

                return majorWithRegisterCount;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<List<object>> GetMajorAdmissionsAndRegisterProcess(string campusId)
        {
            try
            {
                DateTime date = DateTime.Now;
                AdmissionInformation AdmissionInformation = await _context.AdmissionInformations.Include(x => x.AdmissionTimes)
                    .FirstOrDefaultAsync(x => x.StartAdmission <= date && x.EndAdmission >= date && x.CampusId == campusId);


                var majorWithRegisterCount = new List<object>();

                // Loop through each AdmissionTimeId.
                foreach (var AT in AdmissionInformation.AdmissionTimes)
                {
                    // Get major admissions related to the specific AdmissionTimeId.
                    var majors = await _context.MajorAdmissions
                        .Include(x => x.Major)
                        .Include(x => x.TypeAdmissions)
                        .OrderBy(x => x.Major.isVocationalSchool)
                        .Where(x => x.AdmissionTimeId == AT.AdmissionTimeId)
                        .ToListAsync();

                    foreach (var major in majors)
                    {
                        // Count the total number of registrations for the current major.
                        var registerCount = await _context.StudentProfiles
                            .Where(r => r.Major == major.MajorID && r.AdmissionTimeId == AT.AdmissionInformationID)
                            .CountAsync();

                        // Count the number of successful admissions (Passed).
                        var registerCountPass = await _context.StudentProfiles
                            .Where(r => r.Major == major.MajorID
                                        && r.AdmissionTimeId == AT.AdmissionInformationID
                                        && r.TypeofStatusProfile == TypeofStatus.SuccessProfileAdmission
                                        && r.TypeofStatusMajor == TypeofStatusForMajor.Pass)
                            .CountAsync();

                        majorWithRegisterCount.Add(new
                        {
                            MajorId = major.MajorID,
                            MajorName = major.Major?.MajorName,
                            RegisteredCount = registerCount,
                            Target = major.Target,
                            RegisterCountPass = registerCountPass,
                            AdmissionTimeId = AT.AdmissionInformationID // Include the AdmissionTimeId for clarity
                        });
                    }
                }

                return majorWithRegisterCount;
            }
            catch (Exception ex)
            {
                // Log the error and rethrow the exception
                Console.WriteLine(ex);
                throw new Exception("An error occurred while retrieving the major admissions and registration process.", ex);
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
        public async Task<MajorAdmission> GetMajorDetail(string MajorID)
        {

            try
            {
                DateTime date = DateTime.Now;
                var AT = await _context.AdmissionTimes.FirstOrDefaultAsync(x => x.StartRegister <= date && x.EndRegister >= date);
                MajorAdmission major =
                await _context.MajorAdmissions
               .Include(x => x.Major)
               .Include(x => x.Major.Subjects.OrderBy(s => s.SemesterNumber))
                .Include(x => x.TypeAdmissions)
               .Include(x => x.AdmissionTime)
               .SingleOrDefaultAsync(x => x.AdmissionTimeId == AT.AdmissionTimeId && x.MajorID == MajorID);
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
                //var AI = await _context.AdmissionInformations.FirstOrDefaultAsync(x => x.Status == TypeOfAdmissionInformation.Process && x.CampusId == campusId);
                MajorAdmission major = null;
                // await _context.MajorAdmissions
                //.Include(x => x.Major)
                //.Include(x => x.Major.Subjects.OrderBy(s => s.SemesterNumber))
                // .Include(x => x.TypeAdmissions)
                //.Include(x => x.AdmissionInformation)
                //.SingleOrDefaultAsync(x => x.AdmissionInformationID == AI.AdmissionInformationID && x.MajorID == MajorID);
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
        public async Task AddMajorAdmision(MajorAdmission major)
        {
            try
            {
                await _context.MajorAdmissions.AddAsync(major);
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
