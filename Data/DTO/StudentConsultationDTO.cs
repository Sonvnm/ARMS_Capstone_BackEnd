using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class StudentConsultationDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkFB { get; set; }
        public DateTime DateReceive { get; set; }
        public string CampusId { get; set; }
        public string MajorID { get; set; }
    }
    public class StudentConsultation_AO_DTO
    {
        public Guid StudentConsultationId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkFB { get; set; }
        public DateTime DateReceive { get; set; }
        public string MajorID { get; set; }
        public string MajorName { get; set; }
        public StatusConsultation Status { get; set; }
        public string? Notes { get; set; }
        public string CampusId { get; set; }
    }
    public class StudentConsultation_SS_DTO
    {
        public Guid StudentConsultationId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkFB { get; set; }
        public DateTime DateReceive { get; set; }
        public string MajorID { get; set; }
        public string MajorName { get; set; }
        public string? Notes { get; set; }
        public StatusConsultation Status { get; set; }
    }
}
