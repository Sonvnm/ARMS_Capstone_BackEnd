using Data.ArmsContext;
using Data.Models;
using Repository;
using Repository.MajorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.StudentConsultationSer
{
    public class StudentConsultationService : IStudentConsultationService
    {
        private readonly StudentConsultationRepository _studentConsultationRepository;
        public StudentConsultationService(ArmsDbContext context)
        {
            _studentConsultationRepository = new StudentConsultationRepository(context);
        }
        public async Task AddNewStudentConsultation(StudentConsultation studentConsultation) 
            => await _studentConsultationRepository.AddNewStudentConsultation(studentConsultation);

        public async Task<List<StudentConsultation>> GetListStudentConsultation(string campusId) 
            => await _studentConsultationRepository.GetListStudentConsultation(campusId);

        public Task UpdateStudentConsultation(StudentConsultation StudentConsultation)
            => _studentConsultationRepository.UpdateStudentConsultation(StudentConsultation);
    }
}
