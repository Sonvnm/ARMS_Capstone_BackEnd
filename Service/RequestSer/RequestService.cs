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
    public class RequestService : IRequestService
    {
        private readonly RequestRepository _requestChangeMajorRepository;
        public RequestService(ArmsDbContext context)
        {
            _requestChangeMajorRepository = new RequestRepository(context);
        }

        public Task AddNewRequest(Request requestChangeMajor)
            => _requestChangeMajorRepository.AddNewRequest(requestChangeMajor);

        public Task<Request> GetRequestByID(int Id)
        => _requestChangeMajorRepository.GetRequestByID(Id);

        public Task<List<Request>> GetRequestChangeMajors(string campusId)
            => _requestChangeMajorRepository.GetRequestChangeMajors(campusId);

        public Task<List<Request>> GetRequestChangeMajorsByID(Guid Id)
        => _requestChangeMajorRepository.GetRequestChangeMajorsByID(Id);

        public Task<List<Request>> GetRequestWithDrawal(string campusId)
            => _requestChangeMajorRepository.GetRequestWithDrawal(campusId);

        public Task<List<Request>> GetRequestWithDrawalsByID(Guid Id)
        => _requestChangeMajorRepository.GetRequestWithDrawalsByID(Id);

        public Task UpdateRequest(Request request)
        => _requestChangeMajorRepository.UpdateRequest(request);
    }
}
