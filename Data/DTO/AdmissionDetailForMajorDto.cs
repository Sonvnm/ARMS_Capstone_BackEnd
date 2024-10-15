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
    public class AdmissionDetailForMajorDto
    {
        public Guid ADMId { get; set; }
        public int Year { get; set; }
        public decimal TotalScore { get; set; }
        public decimal TotalScoreAcademic { get; set; }
        public bool StatusScore { get; set; }
        public bool StatusScoreAcademic { get; set; }
        public List<SubjectGroupDTO> subjectGroupDTOs { get; set; }
        //public string? SubjectGroupsJson { get; set; }
        //[NotMapped]
        //public List<SubjectGroup>? SubjectGroups
        //{
        //    get => string.IsNullOrEmpty(SubjectGroupsJson)
        //           ? new List<SubjectGroup>()
        //           : JsonSerializer.Deserialize<List<SubjectGroup>>(SubjectGroupsJson);
        //    set => SubjectGroupsJson = JsonSerializer.Serialize(value);
        //}
    }
    public class SubjectGroupDTO
    {
        public string SubjectGroup { get; set; }
        public string SubjectGroupName { get; set; }
    }
}
