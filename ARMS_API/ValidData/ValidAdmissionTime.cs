using Data.DTO;
using Data.Models;
using Service.AdmissionInformationSer;
using Service.StudentProfileServ;

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
        //internal void ValidateAdmissionTimes(AdmissionInformation_Add_DTO admissionInformationDTO)
        //{
        //    try
        //    {
        //        AdmissionTime_Add_DTO previousAdmissionTime = null;
        //        AdmissionTime_Add_DTO nextAdmissionTime = null;
        //        if (admissionInformationDTO.AdmissionTimes != null && admissionInformationDTO.AdmissionTimes.Any())
        //        {
        //            foreach (var admissionTime in admissionInformationDTO.AdmissionTimes)
        //            {
        //                // Kiểm tra xem thời gian của AdmissionTime có nằm trong khoảng thời gian của AdmissionInformation không
        //                if (admissionTime.StartRegister < admissionInformationDTO.StartAdmission || admissionTime.StartRegister > admissionInformationDTO.EndAdmission)
        //                {
        //                    throw new Exception($"Thời gian bắt đầu đăng ký của {admissionTime.AdmissionTimeName} không nằm trong khoảng thời gian tuyển sinh.");
        //                }

        //                if (admissionTime.EndRegister < admissionInformationDTO.StartAdmission || admissionTime.EndRegister > admissionInformationDTO.EndAdmission)
        //                {
        //                    throw new Exception($"Thời gian kết thúc đăng ký của {admissionTime.AdmissionTimeName} không nằm trong khoảng thời gian tuyển sinh.");
        //                }

        //                if (admissionTime.StartAdmission < admissionInformationDTO.StartAdmission || admissionTime.StartAdmission > admissionInformationDTO.EndAdmission)
        //                {
        //                    throw new Exception($"Thời gian bắt đầu tuyển sinh của {admissionTime.AdmissionTimeName} không nằm trong khoảng thời gian tuyển sinh.");
        //                }

        //                if (admissionTime.EndAdmission < admissionInformationDTO.StartAdmission || admissionTime.EndAdmission > admissionInformationDTO.EndAdmission)
        //                {
        //                    throw new Exception($"Thời gian kết thúc tuyển sinh của {admissionTime.AdmissionTimeName} không nằm trong khoảng thời gian tuyển sinh.");
        //                }

        //                // Kiểm tra nếu thời gian bắt đầu lớn hơn kết thúc cho từng thời gian của AdmissionTime
        //                if (admissionTime.StartRegister >= admissionTime.EndRegister)
        //                {
        //                    throw new Exception($"Thời gian bắt đầu đăng ký của {admissionTime.AdmissionTimeName} phải nhỏ hơn thời gian kết thúc đăng ký.");
        //                }

        //                if (admissionTime.StartAdmission >= admissionTime.EndAdmission)
        //                {
        //                    throw new Exception($"Thời gian bắt đầu tuyển sinh của {admissionTime.AdmissionTimeName} phải nhỏ hơn thời gian kết thúc tuyển sinh.");
        //                }

        //            }
        //            foreach (var at in admissionInformationDTO.AdmissionTimes.OrderBy(a => a.StartRegister))  // Sắp xếp theo StartRegister
        //            {
        //                // Cập nhật previousAdmissionTime và nextAdmissionTime
        //                if (at.StartRegister < previousAdmissionTime.StartRegister || previousAdmissionTime==null)
        //                {
        //                    previousAdmissionTime = at;
        //                }

        //                // Kiểm tra nếu đợt hiện tại có thời gian bắt đầu sau thời gian kết thúc của đợt trước
        //                if (at.StartRegister > nextAdmissionTime.EndRegister || nextAdmissionTime==null)
        //                {
        //                    nextAdmissionTime = at;
        //                }
        //                //// Kiểm tra xem nếu đợt tuyển sinh hiện tại là đợt trước hay đợt sau đợt mới
        //                //if (previousAdmissionTime != null && nextAdmissionTime == null && at.StartRegister > previousAdmissionTime.StartAdmission)
        //                //{
        //                //    nextAdmissionTime = at;
        //                //}

        //                // Kiểm tra với đợt tuyển sinh trước đó
        //                if (previousAdmissionTime != null)
        //                {
        //                    // Kiểm tra thời gian của đợt mới với đợt trước
        //                    if (at.StartRegister < previousAdmissionTime.EndRegister || at.EndRegister < previousAdmissionTime.EndRegister)
        //                    {
        //                        throw new Exception($"Thời gian đăng ký của đợt {at.AdmissionTimeName} không hợp lệ với đợt tuyển sinh trước.");
        //                    }

        //                    if (at.StartAdmission < previousAdmissionTime.EndAdmission || at.EndAdmission < previousAdmissionTime.EndRegister)
        //                    {
        //                        throw new Exception($"Thời gian tuyển sinh của đợt {at.AdmissionTimeName} không hợp lệ với đợt tuyển sinh trước.");
        //                    }
        //                }

        //                // Kiểm tra với đợt tuyển sinh sau đó
        //                if (nextAdmissionTime != null)
        //                {
        //                    // Kiểm tra thời gian của đợt mới với đợt sau
        //                    if (at.StartRegister >= nextAdmissionTime.StartRegister || at.EndRegister <= nextAdmissionTime.StartRegister)
        //                    {
        //                        throw new Exception($"Thời gian đăng ký của đợt {at.AdmissionTimeName} không hợp lệ với đợt tuyển sinh sau.");
        //                    }

        //                    if (at.StartAdmission >= nextAdmissionTime.StartAdmission || at.EndAdmission <= nextAdmissionTime.StartAdmission)
        //                    {
        //                        throw new Exception($"Thời gian tuyển sinh của đợt {at.AdmissionTimeName} không hợp lệ với đợt tuyển sinh sau.");
        //                    }
        //                }

        //                //previousAdmissionTime = at;
        //            }

        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

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

                // Sắp xếp các AdmissionTimes theo StartAdmission
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
