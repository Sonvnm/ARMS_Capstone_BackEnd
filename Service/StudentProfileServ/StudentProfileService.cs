using Data.ArmsContext;
using Data.Models;
using Repository;
using Repository.StudentProfileRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service.StudentProfileServ
{
    public class StudentProfileService : IStudentProfileService
    {
        private readonly StudentProfileRepository _studentProfileRepository;
        public StudentProfileService(ArmsDbContext context)
        {
            _studentProfileRepository = new StudentProfileRepository(context);
        }
        public async Task<Guid> AddStudentProfile(StudentProfile StudentProfile)
        {
            try
            {
            Guid id = await _studentProfileRepository.AddStudentProfile(StudentProfile);
                return id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<StudentProfile> GetExistCCCDStudent(string CID)
            => await _studentProfileRepository.GetExistCCCDStudent(CID);

        public async Task<List<StudentProfile>> GetRegisterAdmission(string CampusId)
        {
            var list = await _studentProfileRepository.GetRegisterAdmission(CampusId);
            return list.Where(x=>x.TypeofStatusProfile == TypeofStatus.ConfirmSuccessProfileRegister || x.TypeofStatusProfile == TypeofStatus.SuccessProfileAdmission).ToList();
        }
        public async Task<List<StudentProfile>> GetRegisterAdmissionForAC(string CampusId)
        {
            var list = await _studentProfileRepository.GetRegisterAdmission(CampusId);
            return list;
        }
        public async Task<List<StudentProfile>> GetAdmission(string CampusId)
        {
            var list = await _studentProfileRepository.GetRegisterAdmission(CampusId);
            return list.Where(x => x.TypeofStatusProfile == TypeofStatus.ConfirmSuccessProfileAdmission && x.TypeofStatusProfile == TypeofStatus.SuccessProfileAdmission).ToList();
        }
        public async Task<StudentProfile?> GetStudentProfileBySpCIIdAsync(string id)
            => await _studentProfileRepository.GetStudentProfileBySpCIIdAsync(id);

        public async Task<StudentProfile?> GetStudentProfileBySpIdAsync(Guid id)
            => await _studentProfileRepository.GetStudentProfileBySpIdAsync(id);

        public async Task<bool> isExistCCCDStudent(string CID) => await _studentProfileRepository.isExistCCCDStudent(CID);

        public async Task<bool> isExistEmailStudent(string email) => await _studentProfileRepository.isExistEmailStudent(email);

        public async Task<bool> isExistPhoneNumberStudent(string phonenumber) => await _studentProfileRepository.isExistPhoneNumberStudent(phonenumber);

        public async Task<StudentProfile> UpdateStudentRegister(StudentProfile StudentProfile) => await _studentProfileRepository.UpdateStudentRegister(StudentProfile);

        public Task<int> CountAdmissionMajor(string majorId, string CampusId)
        => _studentProfileRepository.CountAdmissionMajor(majorId, CampusId);

        public Task<List<StudentProfile>> GetRegisterAdmission(int ATId)
        => _studentProfileRepository.GetRegisterAdmission(ATId);
    }
}
