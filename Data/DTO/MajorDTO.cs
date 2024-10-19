using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class MajorDTO
    {
        public string MajorID { get; set; }
        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public string? Description { get; set; }
        public decimal? Tuition { get; set; }
        public int? Target { get; set; }
        public string? TimeStudy { get; set; }
        public virtual ICollection<SubjectDTO>? Subjects { get; set; }
        public virtual ICollection<TypeAdmissionDTO>? TypeAdmissions { get; set; }
    }
    public class Major_Admin_DTO
    {
        public string MajorID { get; set; }
        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public string? Description { get; set; }
        public decimal? Tuition { get; set; }
        public int? Target { get; set; }
        public string? TimeStudy { get; set; }
        public bool isVocationalSchool { get; set; }
        public bool Status { get; set; }// Admission status
        public virtual ICollection<SubjectDTO>? Subjects { get; set; }

    }
    public class Major_Manage_DTO
    {
        public string MajorID { get; set; }
        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public string? Description { get; set; }
        public decimal? Tuition { get; set; }
        public string? TimeStudy { get; set; }
        public bool isVocationalSchool { get; set; }
        public string CampusId { get; set; }
        public virtual ICollection<SubjectDTO>? Subjects { get; set; }
    }
    public class Major_Admission_DTO
    {
        public string MajorID { get; set; }
        public int? Target { get; set; } = 0;
        public bool Status { get; set; }
        public virtual ICollection<TypeAdmissionDTO>? TypeAdmissions { get; set; }
    }
    public class Major_Admission_Council_DTO
    {
        public string MajorID { get; set; }
        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public string? Description { get; set; }
        public int? Target { get; set; }
        public bool isVocationalSchool { get; set; }
        public bool Status { get; set; }// Admission status
        public virtual ICollection<TypeAdmissionDTO>? TypeAdmissions { get; set; }

    }
}
