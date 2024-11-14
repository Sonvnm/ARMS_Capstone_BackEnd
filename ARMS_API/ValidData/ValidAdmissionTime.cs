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
                foreach (var at in admissionInformationSort)
                {
                    // Cập nhật previousAdmissionTime và nextAdmissionTime
                    if (at.StartRegister < admissionTimeDTO.StartRegister)
                    {
                        previousAdmissionTime = at;
                    }

                    // Kiểm tra nếu đợt hiện tại có thời gian bắt đầu sau thời gian kết thúc của đợt trước
                    if (at.StartRegister > admissionTimeDTO.StartRegister)
                    {
                        nextAdmissionTime = at;
                    }
                    // Kiểm tra với đợt tuyển sinh trước đó
                    if (previousAdmissionTime != null)
                    {
                        // Kiểm tra thời gian đăng ký của đợt mới với đợt trước 
                        if (admissionTimeDTO.StartRegister < previousAdmissionTime.EndRegister || admissionTimeDTO.EndRegister < previousAdmissionTime.EndRegister)
                        {
                            throw new Exception($"Thời gian đăng ký của đợt {admissionTimeDTO.AdmissionTimeName} không hợp lệ với đợt tuyển sinh trước.");
                        }

                        // Kiểm tra thời gian tuyển sinh của đợt mới với đợt trước
                        if (admissionTimeDTO.StartAdmission < previousAdmissionTime.EndAdmission || admissionTimeDTO.EndAdmission < previousAdmissionTime.EndAdmission)
                        {
                            throw new Exception($"Thời gian tuyển sinh của đợt {admissionTimeDTO.AdmissionTimeName} không hợp lệ với đợt tuyển sinh trước.");
                        }
                    }

                    // Kiểm tra với đợt tuyển sinh sau đó
                    if (nextAdmissionTime != null)
                    {
                        // Kiểm tra thời gian đăng ký của đợt mới với đợt sau
                        if (admissionTimeDTO.StartRegister >= nextAdmissionTime.StartRegister || admissionTimeDTO.EndRegister >= nextAdmissionTime.StartRegister)
                            throw new Exception($"Thời gian đăng ký của đợt {admissionTimeDTO.AdmissionTimeName} không hợp lệ với đợt tuyển sinh sau.");
                        // Kiểm tra thời gian tuyển sinh của đợt mới với đợt sau
                        if (admissionTimeDTO.StartAdmission >= nextAdmissionTime.StartAdmission || admissionTimeDTO.EndAdmission >= nextAdmissionTime.StartAdmission)
                        {
                            throw new Exception($"Thời gian tuyển sinh của đợt {admissionTimeDTO.AdmissionTimeName} không hợp lệ với đợt tuyển sinh sau.");
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        internal async Task ValidDataAdmissionTimeUpdate(AdmissionTime_Add_DTO admissionTimeDTO)
        {
            try
            {
                AdmissionTime previousAdmissionTime = null;
                AdmissionTime nextAdmissionTime = null;

                // Lấy thông tin tuyển sinh từ dịch vụ
                AdmissionInformation admissionInformation = await _admissionInformationService.GetAdmissionInformationById(admissionTimeDTO.AdmissionInformationID);

                // Kiểm tra thời gian đăng ký và tuyển sinh nằm trong khoảng thời gian tuyển sinh
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
                // Lọc và sắp xếp các AdmissionTime hiện có
                var admissionInformationSort = admissionInformation.AdmissionTimes
                    .Where(a => a.AdmissionTimeId != admissionTimeDTO.AdmissionTimeId) // Loại bỏ chính đợt đang được cập nhật
                    .OrderBy(a => a.StartRegister)
                    .ToList();

                foreach (var at in admissionInformationSort)
                {
                    // Cập nhật previousAdmissionTime và nextAdmissionTime
                    if (at.StartRegister < admissionTimeDTO.StartRegister)
                    {
                        previousAdmissionTime = at;
                    }
                    if (at.StartRegister > admissionTimeDTO.StartRegister && nextAdmissionTime == null)
                    {
                        nextAdmissionTime = at;
                    }

                    // Kiểm tra với đợt tuyển sinh trước
                    if (previousAdmissionTime != null)
                    {
                        if (admissionTimeDTO.StartRegister < previousAdmissionTime.EndRegister || admissionTimeDTO.EndRegister < previousAdmissionTime.EndRegister)
                        {
                            throw new Exception($"Thời gian đăng ký của đợt {admissionTimeDTO.AdmissionTimeName} không hợp lệ với đợt tuyển sinh trước.");
                        }

                        if (admissionTimeDTO.StartAdmission < previousAdmissionTime.EndAdmission || admissionTimeDTO.EndAdmission < previousAdmissionTime.EndAdmission)
                        {
                            throw new Exception($"Thời gian tuyển sinh của đợt {admissionTimeDTO.AdmissionTimeName} không hợp lệ với đợt tuyển sinh trước.");
                        }
                    }

                    // Kiểm tra với đợt tuyển sinh sau
                    if (nextAdmissionTime != null)
                    {
                        if (admissionTimeDTO.StartRegister >= nextAdmissionTime.StartRegister || admissionTimeDTO.EndRegister >= nextAdmissionTime.StartRegister)
                        {
                            throw new Exception($"Thời gian đăng ký của đợt {admissionTimeDTO.AdmissionTimeName} không hợp lệ với đợt tuyển sinh sau.");
                        }

                        if (admissionTimeDTO.StartAdmission >= nextAdmissionTime.StartAdmission || admissionTimeDTO.EndAdmission >= nextAdmissionTime.StartAdmission)
                        {
                            throw new Exception($"Thời gian tuyển sinh của đợt {admissionTimeDTO.AdmissionTimeName} không hợp lệ với đợt tuyển sinh sau.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
