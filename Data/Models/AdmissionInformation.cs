using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AdmissionInformation
    {
        public int AdmissionInformationID { get; set; }
        public decimal FeeRegister { get; set; }
        public decimal FeeAdmission { get; set; }
        public int? Year { get; set; }
        public int Admissions { get; set; }
        public DateTime? StartAdmission { get; set; }
        public DateTime? EndAdmission { get; set; }
        public string? AdmissionProfileDescription { get; set; }
        public string CampusId { get; set; }
        public virtual Campus? Campus { get; set; }
        public virtual ICollection<AdmissionTime>? AdmissionTimes { get; set; }


    }
}
