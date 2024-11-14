using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.RequestNotificationSer
{
    public interface IRequestNotificationService
    {
        Task<List<Data.Models.RequestNotification>> GetRequests(Guid? AccountId);
        Task AddNewRequest(Data.Models.RequestNotification request);
    }
}
