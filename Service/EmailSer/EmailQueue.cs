using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EmailSer
{
    public class EmailQueue
    {
        private readonly Queue<EmailRequest> _emails = new Queue<EmailRequest>();
        private readonly object _lock = new object();

        public void Enqueue(EmailRequest emailRequest)
        {
            lock (_lock)
            {
                _emails.Enqueue(emailRequest);
            }
        }

        public EmailRequest? Dequeue()
        {
            lock (_lock)
            {
                return _emails.Count > 0 ? _emails.Dequeue() : null;
            }
        }
        public int Count
        {
            get
            {
                lock (_lock)
                {
                    return _emails.Count;
                }
            }
        }
    }
}
