using Data.ArmsContext;
using Data.Models;
using Repository;
using Repository.MajorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.RequestChangeMajorSer
{
    public class RequestChangeMajorService : IRequestChangeMajorService
    {
        private readonly RequestChangeMajorRepository _requestChangeMajorRepository;
        public RequestChangeMajorService(ArmsDbContext context)
        {
            _requestChangeMajorRepository = new RequestChangeMajorRepository(context);
        }
        public Task<List<RequestChangeMajor>> GetRequestChangeMajors(string campusId)
            => _requestChangeMajorRepository.GetRequestChangeMajors(campusId);

        public Task<List<RequestChangeMajor>> GetRequestChangeMajorsByID(Guid Id)
        => _requestChangeMajorRepository.GetRequestChangeMajorsByID(Id);
    }
}
