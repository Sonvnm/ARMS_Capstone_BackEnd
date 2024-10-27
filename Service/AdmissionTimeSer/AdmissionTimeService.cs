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
        public async Task UpdateAdmissionTime(AdmissionTime AdmissionTime)
        {
            try
            {
                var checkValid = await _admissionTimeRepository.GetAdmissionTime(AdmissionTime.AdmissionTimeId);
                if (checkValid == null) throw new Exception("Không tìm thấy dữ liệu đợt tuyển sinh!");

                var data = await _admissionTimeRepository.GetAdmissionTimes(checkValid.AdmissionInformationID);
                var checkdata = data.Where(x => x.AdmissionTimeId != AdmissionTime.AdmissionTimeId)
                            .OrderBy(x => x.EndRegister)
                            .ToList();

                var previousAdmission = checkdata.LastOrDefault(x => x.EndRegister < AdmissionTime.StartRegister);
                if (previousAdmission != null)
                {
                    if (AdmissionTime.StartRegister <= previousAdmission.EndRegister)
                    {
                        throw new Exception("Thời gian bắt đầu không được trước hoặc bằng thời gian kết thúc của đợt tuyển sinh liền kề trước!");
                    }
                }
                var nextAdmission = checkdata.FirstOrDefault(x => x.StartRegister > AdmissionTime.EndRegister);

                if (nextAdmission != null && AdmissionTime.EndRegister >= nextAdmission.StartRegister)
                {
                    throw new Exception("Thời gian kết thúc không được sau hoặc bằng thời gian bắt đầu của đợt tuyển sinh liền kề sau!");
                }
                checkValid.AdmissionTimeName = AdmissionTime.AdmissionTimeName;
                checkValid.EndAdmission = AdmissionTime.EndAdmission;
                checkValid.StartAdmission = AdmissionTime.StartAdmission;
                checkValid.StartRegister = AdmissionTime.StartRegister;
                checkValid.EndRegister = AdmissionTime.EndRegister;
                
                await _admissionTimeRepository.UpdateAdmissionTime(checkValid);
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
