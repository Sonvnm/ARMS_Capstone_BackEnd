using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Subject
    {
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfCredits { get; set; }
        public int SemesterNumber { get; set; }
        public string StudyTime { get; set; }
        public string? Note { get; set; }
        public string MajorID { get; set; }
        public virtual Major Major { get; set; }
    }
}
