using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AdmissionGroup
    {
        public int AdmissionGroupId { get; set; }
        public int Year { get; set; }
        public decimal TotalScore { get; set; }
        public decimal TotalScoreAcademic { get; set; }
        public bool StatusScore { get; set; }
        public bool StatusScoreAcademic { get; set; }
        public SubjectGroup SubjectGroup { get; set; }
        public string CampusId { get; set; }
        public virtual Campus? Campus { get; set; }
    }
}
