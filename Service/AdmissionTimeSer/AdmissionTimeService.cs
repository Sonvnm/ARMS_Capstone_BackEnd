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
    public class AdmissionTimeService
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

    }
}
