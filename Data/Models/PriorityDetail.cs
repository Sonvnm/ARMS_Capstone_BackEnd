using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class PriorityDetail
    {
        public int PriorityID { get; set; }
        public string PriorityName { get; set; }
        public string PriorityDescription { get; set; }
        public TypeOfPriority TypeOfPriority { get; set; }
        public virtual ICollection<StudentProfile> StudentProfiles { get; set; }
    }
}
