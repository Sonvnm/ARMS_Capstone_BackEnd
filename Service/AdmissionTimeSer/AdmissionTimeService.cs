using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.ArmsContext;
using Data.Models;
using Repository;

namespace Service.AdmissionTimeSer
{
    public class AdmissionTimeService : IAdmissionTimeService
    {
        private readonly AdmissionTimeRepository _admissionTimeRepository;
        /*private readonly AdmissionInfomationRepository _admissionInfomationRepository;*/
        public AdmissionTimeService(ArmsDbContext context)
        {
            _admissionTimeRepository = new AdmissionTimeRepository(context);
            //_admissionInfomationRepository = new AdmissionInfomationRepository(context);
        }
        public async Task AddAdmissionTime(AdmissionTime AdmissionTime)
        {
            try
            {
                var data = await _admissionTimeRepository.GetAdmissionTimes(AdmissionTime.AdmissionInformationID);
                var checkdata = data.Where(x => x.AdmissionInformationID == AdmissionTime.AdmissionInformationID).ToList();
                //await _admissionTimeRepository.AddAdmissionTime(AdmissionTime);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Task<AdmissionTime> GetAdmissionTime(int AIId)
            => _admissionTimeRepository.GetAdmissionTime(AIId);
        public async Task<List<AdmissionTime>> GetAdmissionTimes(string CampusId)
        {
            // lấy ra năm đang tuyển sinh
            //var AI = await _admissionInfomationRepository.GetAdmissionInformationProcess(CampusId);
            var result = await _admissionTimeRepository.GetAdmissionTimes(CampusId);
            var respone = result.Where(x => x.AdmissionInformationID == AI.AdmissionInformationID).ToList();
            return respone;
        }
        public async Task<AdmissionTime> GetAdmissionTime(string CampusId)
        {
            DateTime date = DateTime.Now;
            //// lấy ra năm đang tuyển sinh
            //var AI = await _admissionInfomationRepository.GetAdmissionInformationProcess(CampusId);
            var result = await _admissionTimeRepository.GetAdmissionTimes(CampusId);
            var respone = result.Where(x => x.AdmissionInformationID == AI.AdmissionInformationID).ToList();
            var AT = respone.FirstOrDefault(x => x.StartRegister <= date && x.EndRegister >= date);
            return AT;
        }

    }
}
