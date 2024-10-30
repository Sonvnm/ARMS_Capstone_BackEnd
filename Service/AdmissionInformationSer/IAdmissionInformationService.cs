using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AdmissionInformationSer
{
    public interface IAdmissionInformationService
    {
        Task<AdmissionInformation> GetAdmissionInformationByStatus(string campus);
        Task<AdmissionInformation> GetAdmissionInformationProcess(string campus);
        Task<List<AdmissionInformation>> GetAdmissionInformation(string campus);
        Task UpdateAdmissionInformation(AdmissionInformation AdmissionInformation);
        Task Add(AdmissionInformation AdmissionInformation);
        Task<AdmissionInformation> GetAdmissionInformationById(int AdmissionInformationID);
    }
}
