using Data.ArmsContext;
using Data.Models;
using Repository;
using Repository.MajorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.RequestNotificationSer
{
    public class RequestNotificationService : IRequestNotificationService
    {
        private readonly RequestNotificationRepository _requestNotificationRepository;
        public RequestNotificationService(ArmsDbContext context)
        {
            _requestNotificationRepository = new RequestNotificationRepository(context);
        }
        public Task AddNewRequest(RequestNotification request)
            => _requestNotificationRepository.AddNewRequest(request);

        public Task<List<RequestNotification>> GetRequests(Guid? AccountId)
        => _requestNotificationRepository.GetRequests(AccountId);
    }
}
