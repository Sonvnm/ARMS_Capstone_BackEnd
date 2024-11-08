using Data.DTO;
using Data.Models;
using Service.AdmissionInformationSer;

namespace ARMS_API.ValidData
{
    public class ValidAdmissionTime
    {
        private UserInput _userInput;
        private IAdmissionInformationService _admissionInformationService;
        public ValidAdmissionTime(UserInput userInput, IAdmissionInformationService admissionInformationService)
        {
            _userInput = userInput;
            _admissionInformationService = admissionInformationService;
        }
        public async Task ValidDataAdmissionTime(AdmissionTime_Add_DTO admissionTimeDTO)
        {
            try
            {
                AdmissionTime previousAdmissionTime = null;
                AdmissionTime nextAdmissionTime = null;

                // Lấy thông tin tuyển sinh từ dịch vụ
                AdmissionInformation admissionInformation = await _admissionInformationService.GetAdmissionInformationById(admissionTimeDTO.AdmissionInformationID);
                if (admissionTimeDTO.StartRegister < admissionInformation.StartAdmission
                    || admissionTimeDTO.StartRegister > admissionInformation.EndAdmission
                    )
                {
                    throw new Exception($"Thời gian bắt đầu đăng ký của {admissionTimeDTO.AdmissionTimeName} không nằm trong khoảng thời gian tuyển sinh.");
                }

                if (admissionTimeDTO.EndRegister < admissionInformation.StartAdmission
                    || admissionTimeDTO.EndRegister > admissionInformation.EndAdmission
                    )
                {
                    throw new Exception($"Thời gian kết thúc đăng ký của {admissionTimeDTO.AdmissionTimeName} không nằm trong khoảng thời gian tuyển sinh.");
                }

                if (admissionTimeDTO.StartAdmission < admissionInformation.StartAdmission
                    || admissionTimeDTO.StartAdmission > admissionInformation.EndAdmission
                    )
                {
                    throw new Exception($"Thời gian bắt đầu tuyển sinh của {admissionTimeDTO.AdmissionTimeName} không nằm trong khoảng thời gian tuyển sinh.");
                }

                if (admissionTimeDTO.EndAdmission < admissionInformation.StartAdmission
                    || admissionTimeDTO.EndAdmission > admissionInformation.EndAdmission
                    )
                {
                    throw new Exception($"Thời gian kết thúc tuyển sinh của {admissionTimeDTO.AdmissionTimeName} không nằm trong khoảng thời gian tuyển sinh.");
                }
                var admissionInformationSort = admissionInformation.AdmissionTimes.OrderBy(a => a.StartRegister).ToList();

                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
