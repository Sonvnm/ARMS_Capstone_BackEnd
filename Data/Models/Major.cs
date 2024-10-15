using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Major
    {
        public string MajorID { get; set; }// mã ngành
        public string MajorCode { get; set; }// số mã ngành
        public string MajorName { get; set; }
        public string? Description { get; set; }
        
        public string? TimeStudy { get; set; }
        public bool isVocationalSchool { get; set; }
        public string CampusId { get; set; }
        public decimal? Tuition { get; set; }
        public virtual Campus? Campus { get; set; }
        public virtual ICollection<Subject>? Subjects { get; set; }
        public virtual ICollection<Account>? Accounts { get; set; }
        public virtual ICollection<StudentConsultation>? StudentConsultations { get; set; }
        public virtual ICollection<Request>? RequestChangeMajorsN { get; set; }
        public virtual ICollection<Request>? RequestChangeMajorsO { get; set; }
        public virtual ICollection<StudentProfile>? StudentProfile1 { get; set; }
        public virtual ICollection<StudentProfile>? StudentProfile2 { get; set; }
        public virtual ICollection<MajorAdmission>? MajorAdmissions { get; set; }

    }
}
