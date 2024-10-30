using Data.ArmsContext;
using Data.Models;
using Repository;
using Repository.MajorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.PriorityService
{
    public class PriorityService : IPriorityService
    {
        private readonly PriorityRepository _priorityRepository;
        public PriorityService(ArmsDbContext context)
        {
            _priorityRepository = new PriorityRepository(context);
        }
        public Task<List<PriorityDetail>> GetPriorities() => _priorityRepository.GetPriorities();
    }
}
