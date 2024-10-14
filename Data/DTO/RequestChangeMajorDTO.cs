using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class RequestChangeMajorDTO
    {
        public int RequestID { get; set; }
        public string MajorID { get; set; }
        public string MajorName { get; set; }
        public DateTime DateRequest { get; set; }
        public string Description { get; set; }
        public string FileReasonRequestChangeMajor { get; set; }
        public bool Status { get; set; }
    }
}
