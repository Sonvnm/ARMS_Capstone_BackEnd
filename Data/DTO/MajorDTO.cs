using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class MajorDTO
    {
        public string MajorID { get; set; }
        public string MajorCode { get; set; }
        public bool Status { get; set; }
        public string MajorName { get; set; }
        public string? Description { get; set; }
        public decimal? Tuition { get; set; }
        public int? Target { get; set; } 
        public string? TimeStudy { get; set; }
        public bool isVocationalSchool { get; set; }
        public decimal? TotalScore { get; set; }
        public decimal? TotalScoreAcademic { get; set; }
        public List<SubjectGroupDTO> subjectGroupDTOs { get; set; }
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
        public int AdmissionTimeId { get; set; }
        public string MajorID { get; set; }
        public bool Status { get; set; }
        public int? Target { get; set; }
        public decimal? TotalScore { get; set; }
        public decimal? TotalScoreAcademic { get; set; }
        public string? SubjectGroupsJson { get; set; }
        public virtual ICollection<TypeAdmissionDTO>? TypeAdmissions { get; set; }
    }
    public class Major_Admission_Council_DTO
    {
        public string MajorID { get; set; }
        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public string? Description { get; set; }
        public decimal? Tuition { get; set; }
        public int? Target { get; set; }
        public string? TimeStudy { get; set; }
        public bool isVocationalSchool { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<SubjectDTO>? Subjects { get; set; }
        public virtual ICollection<TypeAdmissionDTO>? TypeAdmissions { get; set; }

    }
    public class Major_RequestChange_DTO
    {
        public string MajorID { get; set; }
        public string MajorName { get; set; }
    }
    public class Major_AC_DTO
    {
        public int AdmissionTimeId { get; set; }
        public string MajorID { get; set; }
        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public bool Status { get; set; }
        public int? Target { get; set; }
        public decimal? TotalScore { get; set; }
        public decimal? TotalScoreAcademic { get; set; }
        public List<SubjectGroupDTO> subjectGroupDTOs { get; set; }
        public virtual ICollection<TypeAdmissionDTO>? TypeAdmissions { get; set; }
    }
    public class Major_Add_DTO
    {
        public int AdmissionInformationID { get; set; }
        public string MajorID { get; set; }
        public bool Status { get; set; }
        public int? Target { get; set; }
        public decimal? TotalScore { get; set; }
        public decimal? TotalScoreAcademic { get; set; }
        public string? SubjectGroupsJson { get; set; }
    }

}
