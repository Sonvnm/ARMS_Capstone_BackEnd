using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AdmissionTimeDTO
    {
        public int AdmissionTimeID { get; set; }
        public string AdmissionTimeName { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }

    }
    public class AdmissionTime_Admission_DTO
    {
        public int AIId { get; set; }
        public string AdmissionInformationName { get; set; }
        public int Year { get; set; }
        public DateTime StartRegister { get; set; }
        public DateTime EndRegister { get; set; }
        public DateTime StartAdmission { get; set; }
        public DateTime EndAdmission { get; set; }
    }
    public class AdmissionTime_Add_DTO
    {
        public int AIId { get; set; }
        public string AdmissionInformationName { get; set; }
        public int Year { get; set; }
        public DateTime StartRegister { get; set; }
        public DateTime EndRegister { get; set; }
        public DateTime StartAdmission { get; set; }
        public DateTime EndAdmission { get; set; }
        public string CampusId { get; set; }
    }
}
