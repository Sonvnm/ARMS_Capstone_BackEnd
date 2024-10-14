using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Slider
    {
        public int SliderId { get; set; }
        public string Img { get; set; }
        public string CampusId { get; set; }
        public virtual Campus Campus { get; set; }
    }
}
