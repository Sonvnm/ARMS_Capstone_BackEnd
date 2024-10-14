using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AdmissionTime
    {
        public int AIId { get; set; }
        public string AdmissionInformationName { get; set; }
        public int Year { get; set; }
        public DateTime StartRegister { get; set;}
        public DateTime EndRegister { get; set; }
        public DateTime StartAdmission { get; set; }
        public DateTime EndAdmission { get; set; }
        public string CampusId { get; set; }
        public virtual Campus? Campus { get; set; }
    }
}