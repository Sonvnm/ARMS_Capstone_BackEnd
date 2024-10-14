using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data.Models
{
    public class MajorAdmission
    {
        public int AdmissionTimeId { get; set; }
        public string MajorID { get; set; }
        public bool Status { get; set; }
        public int? Target { get; set; }
        public decimal? TotalScore { get; set; }
        public decimal? TotalScoreAcademic { get; set; }
        public string? SubjectGroupsJson { get; set; }
        [NotMapped]
        public List<SubjectGroup>? SubjectGroups
        {
            get => string.IsNullOrEmpty(SubjectGroupsJson)
                   ? new List<SubjectGroup>()
                   : JsonSerializer.Deserialize<List<SubjectGroup>>(SubjectGroupsJson);
            set => SubjectGroupsJson = JsonSerializer.Serialize(value);
        }
        public virtual ICollection<TypeAdmission>? TypeAdmissions { get; set; }
        public virtual Major? Major { get; set; }
        public virtual AdmissionTime? AdmissionTime { get; set; }
    }
}
