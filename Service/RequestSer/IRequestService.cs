using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.RequestChangeMajorSer
{
    public interface IRequestService
    {
        Task<List<Request>> GetRequestChangeMajors(string campusId);
        Task<List<Request>> GetRequestChangeMajorsByID(Guid Id);
        Task AddNewRequest(Request requestChangeMajor);
        Task UpdateRequest(Request request);
        Task<Request> GetRequestByID(int Id);
        Task<List<Data.Models.Request>> GetRequestWithDrawal(string campusId);
        Task<List<Data.Models.Request>> GetRequestWithDrawalsByID(Guid Id);
    }
}
