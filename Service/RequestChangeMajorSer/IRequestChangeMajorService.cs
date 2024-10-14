using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.RequestChangeMajorSer
{
    public interface IRequestChangeMajorService
    {
        Task<List<RequestChangeMajor>> GetRequestChangeMajors(string campusId);
        Task<List<RequestChangeMajor>> GetRequestChangeMajorsByID(Guid Id);
    }
}
