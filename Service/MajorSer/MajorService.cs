using Data.ArmsContext;
using Data.DTO;
using Data.Models;
using Repository;
using Repository.MajorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.MajorSer
{
    public class MajorService : IMajorService
    {
        private readonly MajorRepository _majorRepository;
        public MajorService(ArmsDbContext context)
        {
            _majorRepository = new MajorRepository(context);
        }
        public async Task<List<Major>> GetMajors(string campusId)
        {
            var result = await _majorRepository.GetMajors(campusId);
            return result;

        }

        public async Task<Major> GetMajor(string MajorID)
        {
            return await _majorRepository.GetMajor(MajorID);
        }
        public async Task<List<MajorAdmission>> GetMajorsIsVocationalSchool(string campusId)
        {
            var result = await _majorRepository.GetMajorAdmissions(campusId);
            var activeMajors = result.Where(major => major.Major.isVocationalSchool == true && major.Status==true).ToList();
            return activeMajors;
        }
        public async Task<List<MajorAdmission>> GetMajorsIsCollege(string campusId)
        {
            var result = await _majorRepository.GetMajorAdmissions(campusId);
            var activeMajors = result.Where(major => major.Major.isVocationalSchool == false && major.Status == true).ToList();
            return activeMajors;
        }
        public async Task<List<MajorAdmission>> GetMajorsIsCollegeForVocationalSchool(string campusId)
        {
            // Lấy danh sách majors từ repository
            var result = await _majorRepository.GetMajorAdmissions(campusId);

            // Lọc danh sách majors theo các tiêu chí
            var activeMajors = result.Where(major =>
                !major.Major.isVocationalSchool &&  // Không phải trường nghề
                major.Status &&                     // Major có trạng thái kích hoạt
                major.TypeAdmissions.Any(x => x.TypeDiploma == TypeOfDiploma.LienThong) // Có liên thông
            ).ToList();

            return activeMajors;
        }

        public async Task AddNewMajor(Major major)
        {
            await _majorRepository.AddNewMajor(major);
        }

        public async Task UpdateMajor(Major major)=> await _majorRepository.UpdateMajor(major);

        public async Task<List<MajorAdmission>> GetMajorsManage(string campusId)
        {
            var result = await _majorRepository.GetMajorAdmissions(campusId);
            return result;

        }

        public async Task UpdateMajorAdmission(MajorAdmission Major)
        {
            var majorValid = await _majorRepository.GetMajorDetail(Major.MajorID, Major.AdmissionInformationID);
            if (majorValid == null) throw new Exception("Không tồn tại ngành học");
            majorValid.Status = Major.Status;
            majorValid.Target = Major.Target;
            majorValid.SubjectGroupsJson = Major.SubjectGroupsJson;
            majorValid.TypeAdmissions = Major.TypeAdmissions;
            await _majorRepository.UpdateMajorAdmission(majorValid);
        }

        public Task<MajorAdmission> GetMajorDetail(string MajorID, int AdmissionInformationID)
            => _majorRepository.GetMajorDetail(MajorID, AdmissionInformationID);

        public Task<MajorAdmission> GetMajorDetail(string MajorID, string campusId)
        => _majorRepository.GetMajorDetail(MajorID,campusId);
    }
}
