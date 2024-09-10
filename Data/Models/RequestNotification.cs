using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class RequestNotification
    {
        public Guid? RequestId { get; set; }
        public Guid? AccountId { get; set; }
        public string  Subject { get; set; }
        public string Content { get; set; }
        public DateTime TimeSend { get; set; }
        public Guid? SendTo { get; set; }
        public bool? isRead { get; set; }
        public virtual Account? Account { get; set; }

    }
}
