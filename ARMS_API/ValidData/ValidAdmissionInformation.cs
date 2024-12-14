﻿using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionInformationSer;

namespace ARMS_API.ValidData
{
    public class ValidAdmissionInformation : Controller
    {
        private UserInput _userInput;

        private IAdmissionInformationService _admissionInformationService;
        public ValidAdmissionInformation(UserInput userInput, IAdmissionInformationService admissionInformationService)
        {
            _userInput = userInput;
            _admissionInformationService = admissionInformationService;
        }

        internal async Task ValidDataAdmissionInfor(AdmissionInformation_Update_DTO admissionInformationDTO, string campusId)
        {
            try
            {
                var admissions = await _admissionInformationService.GetAdmissionInformation(campusId);
                // check khóa tuyển sinh
                var admissionNumber = admissions.Any(x => x.Admissions == admissionInformationDTO.Admissions && x.AdmissionInformationID != admissionInformationDTO.AdmissionInformationID);
                if (admissionNumber) throw new Exception("Khóa tuyển sinh đã tồn tại!");
                // năm tuyển sinh
                var admissionYear = admissions.Any(x => x.Year == admissionInformationDTO.Year && x.AdmissionInformationID != admissionInformationDTO.AdmissionInformationID);
                if (admissionYear) throw new Exception("Năm tuyển sinh đã tồn tại!");

                var sortedAdmissions = admissions.OrderBy(a => a.StartAdmission).ToList();
                var currentIndex = sortedAdmissions.FindIndex(a => a.AdmissionInformationID == admissionInformationDTO.AdmissionInformationID);
                if (currentIndex == -1)
                    throw new Exception("Thông tin nhập học không tồn tại.");

                if (admissionInformationDTO.FeeRegister < 100000)
                    throw new Exception("Phí xét tuyển phải trên 100.000 VND");
                if (admissionInformationDTO.FeeAdmission < 100000)
                    throw new Exception("Phí nhập học phải trên 100.000 VND");

                // Nếu không phải bản ghi đầu tiên, kiểm tra thời gian với bản ghi trước đó
                if (currentIndex > 0)
                {
                    var previousAdmission = sortedAdmissions[currentIndex - 1];

                    if (admissionInformationDTO.StartAdmission.HasValue &&
                        previousAdmission.EndAdmission.HasValue &&
                        admissionInformationDTO.StartAdmission <= previousAdmission.EndAdmission)
                    {
                        throw new Exception("Thời gian bắt đầu phải lớn hơn thời gian kết thúc của đợt nhập học trước.");
                    }
                }
                // Nếu không phải bản ghi cuối cùng, kiểm tra thời gian với bản ghi sau đó
                if (currentIndex < sortedAdmissions.Count - 1)
                {
                    var nextAdmission = sortedAdmissions[currentIndex + 1];

                    if (admissionInformationDTO.EndAdmission.HasValue &&
                        nextAdmission.StartAdmission.HasValue &&
                        admissionInformationDTO.EndAdmission >= nextAdmission.StartAdmission)
                    {
                        throw new Exception("Thời gian kết thúc phải nhỏ hơn thời gian bắt đầu của đợt nhập học tiếp theo.");
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        internal async Task ValidDataAdmissionInforAdd(AdmissionInformation_Add_DTO admissionInformationDTO, string campusid)
        {
            try
            {
                var admissions = await _admissionInformationService.GetAdmissionInformation(campusid);
                // check khóa tuyển sinh
                var admissionNumber = admissions.Any(x => x.Admissions == admissionInformationDTO.Admissions);
                if (admissionNumber) throw new Exception("Khóa tuyển sinh đã tồn tại!");
                // năm tuyển sinh
                var admissionYear = admissions.Any(x => x.Year == admissionInformationDTO.Year);
                if (admissionYear) throw new Exception("Năm tuyển sinh đã tồn tại!");

                var sortedAdmissions = admissions.OrderBy(a => a.StartAdmission).ToList();
                if (admissionInformationDTO.FeeRegister < 100000)
                    throw new Exception("Phí xét tuyển phải trên 100.000 VND");
                if (admissionInformationDTO.FeeAdmission < 100000)
                    throw new Exception("Phí nhập học phải trên 100.000 VND");
                AdmissionInformation previousAdmission = null;
                AdmissionInformation nextAdmission = null;
                foreach (var admission in sortedAdmissions)
                {
                    // Tìm đợt tuyển sinh trước đợt này
                    if (admission.StartAdmission < admissionInformationDTO.StartAdmission &&
                        (previousAdmission == null || admission.StartAdmission > previousAdmission.StartAdmission))
                    {
                        previousAdmission = admission;
                    }

                    // Tìm đợt tuyển sinh sau đợt này
                    if (admission.StartAdmission > admissionInformationDTO.StartAdmission &&
                        (nextAdmission == null || admission.StartAdmission < nextAdmission.StartAdmission))
                    {
                        nextAdmission = admission;
                    }
                }

                // Kiểm tra điều kiện thời gian với đợt tuyển sinh trước và sau
                if (previousAdmission != null)
                {
                    DateTime previousEndDate = previousAdmission.EndAdmission ?? DateTime.MinValue;

                    if (admissionInformationDTO.StartAdmission <= previousEndDate)
                    {
                        throw new Exception($"Thời gian bắt đầu của đợt tuyển sinh {admissionInformationDTO.Year} phải sau thời gian kết thúc của đợt tuyển sinh trước ({previousAdmission.Year}).");
                    }
                }

                if (nextAdmission != null)
                {
                    DateTime nextStartDate = nextAdmission.StartAdmission ?? DateTime.MaxValue;

                    if (admissionInformationDTO.EndAdmission >= nextStartDate)
                    {
                        throw new Exception($"Thời gian kết thúc của đợt tuyển sinh {admissionInformationDTO.Year} phải trước thời gian bắt đầu của đợt tuyển sinh sau ({nextAdmission.Year}).");
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
