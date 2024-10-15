using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AdmissionPlanDTO
    {
        public int AdmissionPlanID { get; set; }
        public int TotalTarget { get; set; }
        public string? Prioritize { get; set; }
        public int? YearAdmission { get; set; }
        public virtual CampusDTO Campus { get; set; }
        public virtual ICollection<AdmissionTimeDTO>? AdmissionTimes { get; set; }
    }
}
