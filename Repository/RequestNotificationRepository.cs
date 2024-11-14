using Data.ArmsContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RequestNotificationRepository
    {
        private readonly ArmsDbContext _context;
        public RequestNotificationRepository(ArmsDbContext context) { _context = context; }
        public async Task<List<Data.Models.RequestNotification>> GetRequests(Guid? AccountId)
        {
            try
            {
                var request = _context.RequestNotifications
                    .Where(x => x.AccountId.Equals(AccountId))
                    .ToList();
                return request;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task AddNewRequest(Data.Models.RequestNotification request)
        {
            try
            {
                await _context.RequestNotifications.AddAsync(request);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới không thành công");
            }
        }
    }
}
