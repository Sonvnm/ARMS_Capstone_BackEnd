using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class ResponseLogin
    {
        public string Bear { get; set; }
        public DateTime Expiration { get; set; }
        public string? Role { get; set; }
        public string? CampusId { get; set; }
    }
}
