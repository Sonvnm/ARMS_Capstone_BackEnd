using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class EmailLoginViewModel
    {
        public string Email { get; set; }
        public string CampusId { get; set; } = "Hanoi";
    }
    public class GGLoginViewModel
    {
        public string idToken { get; set; }
    }
}
