using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class StudentConsultation
    {
        public Guid StudentConsultationId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LinkFB { get; set; }
        public StatusConsultation Status { get; set; }
        public DateTime DateReceive { get; set; }
        public string? Notes { get; set; }

        //FK
        public string CampusId { get; set; }
        public string MajorID { get; set; }
        public virtual Campus? Campus { get; set; }
        public virtual Major? Major { get; set; }
    }
}
