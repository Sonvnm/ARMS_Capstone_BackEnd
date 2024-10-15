using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class RequestChangeMajor
    {
        public int RequestID { get; set; }
        public string MajorNew { get; set; }
        public DateTime DateRequest { get; set; }
        public string Description { get; set; }
        public string FileReasonRequestChangeMajor { get; set; }
        public bool Status { get; set; }
        public string CampusId { get; set; }
        public Guid AccountId { get; set; }
        public virtual Major? Major { get; set; }
        public virtual Campus? Campus { get; set; }
        public virtual Account? Account { get; set; }
    }
}
