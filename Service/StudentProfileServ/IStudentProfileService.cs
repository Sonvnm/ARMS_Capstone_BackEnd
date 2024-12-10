using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.StudentProfileServ
{
    public interface IStudentProfileService
    {
        Task<Guid> AddStudentProfile(StudentProfile StudentProfile);
        Task<bool> isExistCCCDStudent(string CID);
        Task<bool> isExistEmailStudent(string email);
        Task<bool> isExistPhoneNumberStudent(string phonenumber);
        Task<StudentProfile> GetExistCCCDStudent(string CID);
        Task<List<StudentProfile>> GetRegisterAdmission(string CampusId);
        Task<StudentProfile?> GetStudentProfileBySpIdAsync(Guid id);
        Task<StudentProfile?> GetStudentProfileBySpCIIdAsync(string id);
        Task<StudentProfile> UpdateStudentRegister(StudentProfile StudentProfile);
        Task<List<StudentProfile>> GetAdmission(string CampusId);
        Task<List<StudentProfile>> GetRegisterAdmissionForAC(string CampusId);
        Task<int> CountAdmissionMajor(string majorId, string CampusId);
        Task<List<StudentProfile>> GetRegisterAdmission(int ATId);
    }
}
