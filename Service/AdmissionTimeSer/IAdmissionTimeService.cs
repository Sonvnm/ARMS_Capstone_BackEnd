using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Service.AdmissionTimeSer
{
    public interface IAdmissionTimeService
    {
        Task<List<AdmissionTime>> GetAdmissionTimes(string CampusId);
        Task AddAdmissionTime(AdmissionTime AdmissionTime);
        Task<AdmissionTime> GetAdmissionTime(string CampusId);
    }
}
