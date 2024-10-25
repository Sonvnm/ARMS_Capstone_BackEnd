using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.StudentConsultationSer
{
    public interface IStudentConsultationService
    {
        Task AddNewStudentConsultation(StudentConsultation studentConsultation);
        Task<List<StudentConsultation>> GetListStudentConsultation(string campusId);
        Task UpdateStudentConsultation(StudentConsultation StudentConsultation);
    }
}
