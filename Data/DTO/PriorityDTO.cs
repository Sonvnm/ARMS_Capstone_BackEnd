using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class PriorityDTO
    {
        public int PriorityID { get; set; }
        public string PriorityName { get; set; }
        public string PriorityDescription { get; set; }
        public string TypeOfPriority { get; set; }
        public int BonusPoint { get; set; }
    }
}
