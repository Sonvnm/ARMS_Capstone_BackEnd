using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class LoginDTO
    {
        public string CampusId { get; set; } = "Hanoi";
        public string username { get; set; }
        public string? password { get; set; }
    }
}
