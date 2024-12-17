using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AcademicTranscript
    {
        public Guid ATId { get; set; }
        public Guid SpId { get; set; }
        public string SubjectName { get; set; }
        public decimal SubjectPoint { get; set; }
        public TypeOfAcademicTranscript TypeOfAcademicTranscript { get; set; }
        public StudentProfile? StudentProfile { get; set; }
    }
}
