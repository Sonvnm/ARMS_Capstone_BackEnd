using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.StudentProfileRepo;
using Service.EmailSer;
using Service.StudentProfileServ;
using System.Collections.Generic;
using System.Security.Cryptography;
using static Data.DTO.RegisterAdmissionProfileDTO;
using static Google.Apis.Requests.BatchRequest;

namespace ARMS_API.Controllers.AdmissionOfficer
{
    [Route("api/admin-officer/[controller]")]
    [ApiController]
    //[Authorize(Roles = "AdminOfficer")]
    public class RegisterAdmissionController : ControllerBase
    {
        private IStudentProfileService _studentProfileService;
        private readonly IMapper _mapper;
        private ValidRegisterAdmission _validInput;
        private UserInput _userInput;
        private readonly IEmailService _emailService;
        public RegisterAdmissionController(IStudentProfileService studentProfileService, IMapper mapper, ValidRegisterAdmission validInput, UserInput userInput,IEmailService emailService)
        {
            _studentProfileService = studentProfileService;
            _mapper = mapper;
            _validInput = validInput;
            _userInput = userInput;
            _emailService = emailService;
        }

        [HttpGet("list-register-admission")]
        public async Task<IActionResult> ListRegisterAdmission(string CampusId, string? Search, int CurrentPage, TypeofStatus? TypeofStatus)
        {
            try
            {
                ResponeModel<AdmissionProfile_AO_DTO> result = new ResponeModel<AdmissionProfile_AO_DTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                List<StudentProfile> response = await _studentProfileService.GetRegisterAdmissionForAC(CampusId);
                // Search
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(sp => sp != null && (
                                    _userInput.NormalizeText(sp.Fullname ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.FullnameParents ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.CitizenIentificationNumber ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.District ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.EmailStudent ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.Nation ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.Note ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.PhoneParents ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.PhoneStudent ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.SpecificAddress ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.AddressRecipientResults ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.SchoolName ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.Ward ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.CIAddress ?? "").Contains(searchTerm)
                                ))
                                .ToList();
                }
                if (TypeofStatus != null)
                {
                    response = response.Where(x=>x.TypeofStatusProfile == TypeofStatus).ToList();
                }

                //mapper

                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var studentProfiles = response
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();
                List<AdmissionProfile_AO_DTO> studentProfile = _mapper.Map<List<AdmissionProfile_AO_DTO>>(studentProfiles);
                result.Item = studentProfile;
                result.TotalItems = response.Count;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
        [HttpGet("get-register-admission/{id}")]
        public async Task<IActionResult> GetRegisterAdmission(string id)
        {
            try
            {
                Guid parseId = Guid.Parse(id);
                StudentProfile stf = await _studentProfileService.GetStudentProfileBySpIdAsync(parseId);
                //mapper
                AdmissionProfile_AO_DTO studentProfile = _mapper.Map<AdmissionProfile_AO_DTO>(stf);
                return Ok(studentProfile);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
        [HttpPut("update-student-register")]
        public async Task<IActionResult> UpdateStudentRegister(AdmissionProfile_AO_DTO AdmissionProfile_DTO)
        {
            try
            {
                StudentProfile responeResult = _mapper.Map<StudentProfile>(AdmissionProfile_DTO);
                if (AdmissionProfile_DTO.TypeofStatusMajor1 == TypeofStatusForMajor.Fail )
                {
                    responeResult.TypeofStatusMajor = TypeofStatusForMajor.Fail;
                    responeResult.TypeofStatusProfile = TypeofStatus.Done;
                }
                await _studentProfileService.UpdateStudentRegister(responeResult);

                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
                });

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpPut("update-student-register-status")]
        public async Task<IActionResult> UpdateStudentRegisterStatus(AdmissionProfile_UpdateStatus_DTO AdmissionProfile_UpdateStatus_DTO)
        {
            try
            {
                StudentProfile stf = await _studentProfileService.GetStudentProfileBySpIdAsync(AdmissionProfile_UpdateStatus_DTO.SpId);
                if (stf == null)
                {
                    return NotFound(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Không tìm thấy hồ sơ!"
                    });
                }
                stf.TypeofStatusProfile = AdmissionProfile_UpdateStatus_DTO.TypeofStatusProfile;
                if (AdmissionProfile_UpdateStatus_DTO.TypeofStatusMajor1 == TypeofStatusForMajor.Fail)
                {
                    stf.TypeofStatusMajor = TypeofStatusForMajor.Fail;
                    stf.TypeofStatusProfile = TypeofStatus.Done;
                    _ = Task.Run(async () =>
                    {
                        var emailRequest = new EmailRequest
                        {
                            ToEmail = stf.EmailStudent,
                            Subject = "Xét duyệt hồ sơ!",
                            Body = $@"<!DOCTYPE html>
                                    <html lang=""en"">
                                    <head>
                                        <meta charset=""UTF-8"">
                                        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                                        <title>Thông tin Đăng ký Tuyển sinh</title>
                                        <style>
                                            body {{  
                                                font-family: Arial, sans-serif;
                                                line-height: 1.6;
                                                margin: 20px;
                                            }}
                                            .container {{
                                                max-width: 800px;
                                                margin: 0 auto;
                                                border: 1px solid #ddd;
                                                border-radius: 10px;
                                                padding: 20px;
                                                background-color: #f9f9f9;
                                            }}
                                            h1 {{
                                                text-align: center;
                                                color: #333;
                                            }}

                                        </style>
                                    </head>
                                    <body>
                                        <div class=""container"">
                                            <h1 style=""color: orange"">Thông báo kết quả tuyển sinh</h1>
                                            <p>Gửi {stf.Fullname},
                                            <p> Lời đầu tiên nhà trường xin gửi lời cảm ơn vì em đã dành sự gian tâm tới nhà trường.
                                            <p> Sau thời gian cân nhắc và xem xét hồ sơ. Nhà trường rất tiếc vì hồ sơ của em chưa đủ điều kiện xét tuyển!
                                            <p> Nhà trường xin gửi lời cảm ơn và chúc em sẽ có thật nhiều thành côgn trong tương lai
                                            <p>Trân trọng,</p>
                                            <p>Phòng tuyển sinh</p>
                                        </div>
                                    </body>
                                    </html>"
                        };

                        await _emailService.SendEmailByHTMLAsync(emailRequest);

                    });
                }
                _ = Task.Run(async () =>
                {
                    var emailRequest = new EmailRequest
                    {
                        ToEmail = stf.EmailStudent,
                        Subject = "Xét duyệt hồ sơ!",
                        Body = $@" <h1 style=""color: orange"">Thông báo kết quả tuyển sinh</h1>
                                            <p>Gửi {stf.Fullname},
                                            <p> Hồ sơ của em đã được phòng tuyển sinh xét duyệt
                                            <p> Trong thời gian tới phòng tuyển sinh sẽ gửi thông báo kế quả tuyển sinh em vui lòng theo dõi email và hồ sơ trên hệ thống để nhận kết quả của mình!
                                            <p>Trân trọng,</p>
                                            <p>Phòng tuyển sinh</p>"
                    };

                    await _emailService.SendEmailByHTMLAsync(emailRequest);

                });

                // Save the updated profile
                await _studentProfileService.UpdateStudentRegister(stf);

                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
                });

            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = "Không tìm thấy hồ sơ!"
                });
            }
        }
    }
}
