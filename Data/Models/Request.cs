using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Request
    {
        public int RequestID { get; set; }
        public string? MajorNew { get; set; }
        public string? MajorOld { get; set; }
        public DateTime DateRequest { get; set; }
        public string Description { get; set; }
        public string? Reply { get; set; }
        public string FileReasonRequestChangeMajor { get; set; }
        public TypeofRequestChangeMajor Status { get; set; }
        public bool isRequestChangeMajor { get; set; }
        public string CampusId { get; set; }
        public Guid AccountId { get; set; }
        public virtual Campus? Campus { get; set; }
        public virtual Account? Account { get; set; }
        public virtual Major? MajorN { get; set; }
        public virtual Major? MajorO { get; set; }
    }
}
