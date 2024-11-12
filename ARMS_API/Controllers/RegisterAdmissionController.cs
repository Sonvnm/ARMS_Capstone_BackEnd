using ARMS_API.Helper;
using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using MimeKit;
using Repository.StudentProfileRepo;
using Service.AccountSer;
using Service.AdmissionInformationSer;
using Service.AdmissionTimeSer;
using Service.CampusSer;
using Service.EmailSer;
using Service.LocationSer;
using Service.MajorSer;
using Service.PayFeeAdmissionSer;
using Service.PriorityService;
using Service.RequestNotificationSer;
using Service.StudentProfileServ;
using System.Security.Cryptography;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterAdmissionController : ControllerBase
    {
        private readonly IStudentProfileService _studentProfileService;
        private readonly IPayFeeAdmissionService _payFeeAdmissionService;
        private readonly IMajorService _majorService;
        private readonly IMapper _mapper;
        private ValidRegisterAdmission _validInput;
        private UserInput _userInput;
        private readonly IEmailService _emailByTextService;
        private readonly IMemoryCache _cache;
        private readonly TimeSpan _otpLifetime = TimeSpan.FromMinutes(5);
        private readonly TokenHealper _tokenHealper;
        private readonly IAdmissionInformationService _admissionInformationService;
        private readonly IAdmissionTimeService _admissionTimeService;
        private readonly IEmailService _emailService;
        private readonly IEmailNotifyService _emailNotifyService;
        private readonly ILocationService _locationService;
        private readonly IPriorityService _priorityService;
        private readonly IAccountService _accountService;
        private readonly IRequestNotificationService _requestNotificationService;
        private readonly ICampusService _campusService;
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        public RegisterAdmissionController(IStudentProfileService studentProfileService,
            IMapper mapper,
            ValidRegisterAdmission validInput,
            UserInput userInput,
            IEmailService emailByTextService,
            IMemoryCache cache,
            TokenHealper tokenHealper,
            IPayFeeAdmissionService payFeeAdmissionService,
            IAdmissionInformationService admissionInformationService,
            IMajorService majorService,
            IEmailService emailService,
            ILocationService locationService,
            IPriorityService priorityService,
            IEmailNotifyService emailNotifyService,
            IAccountService accountService,
            IRequestNotificationService requestNotificationService,
            ICampusService campusService,
            UserManager<Account> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IAdmissionTimeService admissionTimeService
            )
        {
            _studentProfileService = studentProfileService;
            _mapper = mapper;
            _validInput = validInput;
            _userInput = userInput;
            _emailByTextService = emailByTextService;
            _cache = cache;
            _tokenHealper = tokenHealper;
            _payFeeAdmissionService = payFeeAdmissionService;
            _admissionInformationService = admissionInformationService;
            _majorService = majorService;
            _emailService = emailService;
            _locationService = locationService;
            _priorityService = priorityService;
            _emailNotifyService = emailNotifyService;
            _accountService = accountService;
            _requestNotificationService = requestNotificationService;
            _campusService = campusService;
            _userManager = userManager;
            _roleManager = roleManager;
            _admissionTimeService = admissionTimeService;
        }


        [HttpPut("done-profile-admission")]
        public async Task<IActionResult> AddRegisterAdmission([FromBody] AdmissionProfileDTO admissionProfileDTO)
        {
            try
            {
                // check status pay fee
                if (admissionProfileDTO.PayFeeAdmission.TransactionStatus != "00")
                {
                    return BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Vui lòng hoàn thành khoản thanh toán!"
                    });
                }
                //mapper

                StudentProfile studentProfile = await _studentProfileService.GetStudentProfileBySpCIIdAsync(admissionProfileDTO.CitizenIentificationNumber);
                if (studentProfile == null)
                {
                    return NotFound(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không tìm thấy hồ sơ sinh viên!"
                    });
                }
                PayFeeAdmission PayFeeAdmission = _mapper.Map<PayFeeAdmission>(admissionProfileDTO.PayFeeAdmission);
                studentProfile.TypeofStatusProfile = TypeofStatus.SuccessProfileAdmission;
                PayFeeAdmission.isFeeRegister = false;
                studentProfile.PayFeeAdmissions.Add(PayFeeAdmission);
                studentProfile.AdmissionForm = admissionProfileDTO.AdmissionForm;
                studentProfile.BirthCertificate = admissionProfileDTO.BirthCertificate;
                //update profile
                await _studentProfileService.UpdateStudentRegister(studentProfile);
                _ = Task.Run(async () =>
                {

                    var Body = $@"<!DOCTYPE html>
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
                        <h1 style=""color: orange"">Thông tin đăng ký Tuyển sinh</h1>
                        <p>Thân gửi bạn 
                            <strong>{studentProfile.Fullname},</strong>
                        </p>
                        <p>Chúng tôi rất vui vì nhận được sự quan tâm từ bạn. 

                        <p>Hồ sơ của bạn đã được nhập học thành công! Chúng tôi sẽ liên hệ bạn trong thời gian sớm nhất để hòan tất thủ tục nhập học!</p>
                        <p>Trân trọng,</p>
                        <p>Phòng Tuyển sinh</p>
                    </div>
                </body>
                </html>";
                    var emailRequest = new EmailRequestNotify
                    {
                        ToEmail = studentProfile.EmailStudent,
                        Subject = "Thông báo nhập học thành công!",
                        Body = Body,
                    };

                    await _emailNotifyService.SendEmailByHTMLAsync(emailRequest);
                });

                var accounts = await _accountService.GetAccountStudent(studentProfile.CampusId);
                int accountCount = accounts.Count(); // Đếm số tài khoản
                string formattedAccountCount = accountCount.ToString("D4");
                string StudentCode = "";
                string major = "";
                if (studentProfile.TypeofStatusMajor1 == TypeofStatusForMajor.Pass) major = studentProfile.Major1;
                if (studentProfile.TypeofStatusMajor2 == TypeofStatusForMajor.Pass) major = studentProfile.Major2;
                if (accounts != null)
                {

                    var admission = await _admissionInformationService.GetAdmissionInformationById(studentProfile.AdmissionTime.AdmissionInformationID);
                    int admissionName = admission.Admissions;
                    string formattedAdmissionName = admissionName.ToString("D2");
                    StudentCode = major + formattedAdmissionName + formattedAccountCount;
                }
                // tạo request account student

                Account account = new Account()
                {
                    StudentCode = StudentCode,
                    CampusId = studentProfile.CampusId,
                    Email = studentProfile.EmailStudent,
                    Fullname = studentProfile.Fullname,
                    Dob = studentProfile.Dob,
                    isAccountActive = false,
                    Gender = studentProfile.Gender,
                    MajorId = major,
                    Phone = studentProfile.PhoneStudent,
                    SPId = studentProfile.SpId,
                    UserName = StudentCode,
                    NormalizedUserName = "Student",
                    NormalizedEmail = studentProfile.EmailStudent,
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    TypeAccount = TypeAccount.RequestAccountInProcess
                };
                var result = await _userManager.CreateAsync(account, "A123@123a");
                if (result.Succeeded)
                {
                    // Gán vai trò (nếu cần)
                    var role = await _roleManager.FindByNameAsync("Student");
                    if (role != null)
                    {
                        var roleResult = await _userManager.AddToRoleAsync(account, role.Name);
                    }
                }
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Thủ tục nhập học thành công!"
                });
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
        [HttpPost("add-register-admission")]
        public async Task<IActionResult> AddAdmissionProfile([FromBody] RegisterAdmissionProfileDTO registerAdmissionProfileDTO)
        {
            try
            {
                //mapper
                // Map registerAdmissionProfileDTO sang StudentProfile
                StudentProfile studentProfile = _mapper.Map<StudentProfile>(registerAdmissionProfileDTO);

                studentProfile.TypeofStatusProfile = TypeofStatus.WaitingPaymentRegisterAdmission;
                studentProfile.TypeofStatusMajor1 = TypeofStatusForMajor.Pending;
                studentProfile.TypeofStatusMajor2 = TypeofStatusForMajor.Pending;
                studentProfile.TimeRegister = DateTime.Now;

                AdmissionTime response = await _admissionTimeService.GetAdmissionTime(registerAdmissionProfileDTO.CampusId);
                studentProfile.AdmissionTimeId = response.AdmissionTimeId;

                //add new
                await _studentProfileService.AddStudentProfile(studentProfile);

                // send email
                var major = await _majorService.GetMajor(registerAdmissionProfileDTO.Major1);
                string major1 = major.MajorName;
                var majorn2 = await _majorService.GetMajor(registerAdmissionProfileDTO.Major2);
                string major2 = majorn2.MajorName;
                var gender = registerAdmissionProfileDTO.Gender == true ? "Nam" : "Nữ";
                var address = await _locationService.GetFullAddress(registerAdmissionProfileDTO.Province, registerAdmissionProfileDTO.District, registerAdmissionProfileDTO.Ward, registerAdmissionProfileDTO.SpecificAddress);
                //điểm ưu tiên

                var priorities = await _priorityService.GetPriorities();

                // Nếu `priorities` null, `FirstOrDefault` trả về null, và các thuộc tính sẽ không bị gọi lỗi.
                var priority = priorities?.FirstOrDefault(x => x.PriorityID == registerAdmissionProfileDTO.PriorityDetailPriorityID);

                // Sử dụng null-coalescing (`??`) để trả về giá trị rỗng nếu `priority` hoặc `priority.PriorityName` null.
                var priorityName = priority?.PriorityName ?? string.Empty;

                int UT = 0;

                // Kiểm tra null trước khi sử dụng `TypeOfPriority`
                if (priority?.TypeOfPriority == TypeOfPriority.UT1) UT = 2;
                else if (priority?.TypeOfPriority == TypeOfPriority.UT2) UT = 1;

                // Sử dụng null hoặc giá trị mặc định cho `priorityName` và `UT`
                var priorityMessage = !string.IsNullOrEmpty(priorityName)
                    ? $"{priorityName} được cộng {UT} điểm ưu tiên"
                    : "Không có thông tin ưu tiên.";


                // Hình thức xét tuyển
                var TypeOfDiplomaMajor1 = registerAdmissionProfileDTO.TypeOfDiplomaMajor1 switch
                {
                    TypeOfDiploma.Tot_nghiep_THCS => "Tốt nghiệp THCS",
                    TypeOfDiploma.Tot_nghiep_THPT => "Tốt nghiệp THPT",
                    TypeOfDiploma.Tot_nghiep_CD_DH => "Tốt nghiệp CĐ/ĐH",
                    TypeOfDiploma.Xet_hoc_ba_THPT => "Xét học bạ THPT",
                    TypeOfDiploma.LienThong => "Liên thông",
                    TypeOfDiploma.Xet_diem_thi_THPT => "Xét điểm thi THPT",
                    _ => "Không có thông tin"
                };
                var TypeOfDiplomaMajor2 = registerAdmissionProfileDTO.TypeOfDiplomaMajor2 switch
                {
                    TypeOfDiploma.Tot_nghiep_THCS => "Tốt nghiệp THCS",
                    TypeOfDiploma.Tot_nghiep_THPT => "Tốt nghiệp THPT",
                    TypeOfDiploma.Tot_nghiep_CD_DH => "Tốt nghiệp CĐ/ĐH",
                    TypeOfDiploma.Xet_hoc_ba_THPT => "Xét học bạ THPT",
                    TypeOfDiploma.LienThong => "Liên thông",
                    TypeOfDiploma.Xet_diem_thi_THPT => "Xét điểm thi THPT",
                    _ => "Không có thông tin"
                };



                //_ = Task.Run(async () =>
                //{

                //    var Body = $@"<!DOCTYPE html>
                //<html lang=""en"">
                //<head>
                //    <meta charset=""UTF-8"">
                //    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                //    <title>Thông tin Đăng ký Tuyển sinh</title>
                //    <style>
                //        body {{  
                //            font-family: Arial, sans-serif;
                //            line-height: 1.6;
                //            margin: 20px;
                //        }}
                //        .container {{
                //            max-width: 800px;
                //            margin: 0 auto;
                //            border: 1px solid #ddd;
                //            border-radius: 10px;
                //            padding: 20px;
                //            background-color: #f9f9f9;
                //        }}
                //        h1 {{
                //            text-align: center;
                //            color: #333;
                //        }}
                //        table {{
                //            width: 100%;
                //            border-collapse: collapse;
                //            margin: 20px 0;
                //        }}
                //        th, td {{
                //            padding: 10px;
                //            border: 1px solid #ddd;
                //            text-align: left;
                //        }}
                //        th {{
                //            background-color: #f4f4f4;
                //        }}
                //    </style>
                //</head>
                //<body>
                //    <div class=""container"">
                //        <h1 style=""color: orange"">Thông tin đăng ký Tuyển sinh</h1>
                //        <p>Thân gửi bạn 
                //            <strong>{registerAdmissionProfileDTO.Fullname},</strong>
                //        </p>
                //        <p>Chúng tôi rất vui vì nhận được sự quan tâm từ bạn. 
                //            Dưới đây là thông tin đăng ký tuyển sinh của bạn:</p>
                //        <table>
                //            <tr>
                //                <th>Họ và tên</th>
                //                <td>{registerAdmissionProfileDTO.Fullname}</td>
                //            </tr>
                //            <tr>
                //                <th>Ngày sinh</th>
                //                <td>{registerAdmissionProfileDTO.Dob}</td>
                //            </tr>
                //            <tr>
                //                <th>Giới tính</th>
                //                 <td>{gender}</td>
                //            </tr>
                //            <tr>
                //                <th>Dân tộc</th>
                //                <td>{registerAdmissionProfileDTO.Nation}</td>
                //            </tr>
                //            </tr>
                //            <tr>
                //                <th>Địa chỉ</th>
                //                 <td>{address}</td>
                //            </tr>
                //            <tr>
                //                <th>Số căn cước công dân</th>
                //                <td>{registerAdmissionProfileDTO.CitizenIentificationNumber}</td>
                //            </tr>
                //            <tr>
                //                <th>Ngày cấp</th>
                //                <td>{registerAdmissionProfileDTO.CIDate}</td>
                //            </tr>
                //            <tr>
                //                <th>Nơi cấp</th>
                //                <td>{registerAdmissionProfileDTO.CIAddress}</td>
                //            </tr>
                //            <tr>
                //                <th>Email</th>
                //                <td>{registerAdmissionProfileDTO.EmailStudent}</td>
                //            </tr>
                //            <tr>
                //                <th>Số điện thoại</th>
                //                <td>{registerAdmissionProfileDTO.PhoneStudent}</td>
                //            </tr>
                //            <tr>
                //                <th>Trường THPT</th>
                //                <td>{registerAdmissionProfileDTO.SchoolName}</td>
                //            </tr>
                //            <tr>
                //                <th>Năm tốt nghiệp</th>
                //                 <td>{registerAdmissionProfileDTO.YearOfGraduation}</td>
                //            </tr>

                //            <tr>
                //                <th>Thông tin phụ huynh</th>
                //                <td><strong>Họ và tên:</strong> {registerAdmissionProfileDTO.FullnameParents}<br/>
                //                            <strong>Số điện thoại:</strong> {registerAdmissionProfileDTO.PhoneParents}
                //                </td>
                //            </tr>
                //            <tr>
                //                <th>Ngành đăng ký</th>
                //               <td>
                //                    <strong>Ngành 1:</strong> {major1}<br/>
                //                    <strong>Ngành 2:</strong> {major2}
                //                </td>
                //            </tr>
                //            <tr>
                //                <th>Ưu tiên</th>
                //                <td>
                //                    <strong> Đối tượng:</strong> {priorityName}<br/>
                //                        <strong>Mô tả:</strong> {priorityMessage}
                //                </td>
                //            </tr>
                //            <tr>
                //                <th>Hình thức xét tuyển </th>
                //                <td> 
                //                        <strong>Nguyện vọng 1:</strong> {TypeOfDiplomaMajor1}<br/>
                //                        <strong>Nguyện vọng 2:</strong> {TypeOfDiplomaMajor2}
                //                </td>
                //            </tr>


                //        </table>    

                //        <p>Chúng tôi sẽ xử lý thông tin này và sẽ liên hệ lại với bạn trong thời gian sớm nhất.</p>
                //        <p>Trân trọng,</p>
                //        <p>Phòng Tuyển sinh</p>
                //    </div>
                //</body>
                //</html>";
                //    var emailRequest = new EmailRequestNotify
                //    {
                //        ToEmail = registerAdmissionProfileDTO.EmailStudent,
                //        Subject = "Thông báo đăng ký hồ sơ tuyển sinh thành công!",
                //        Body = Body,
                //    };

                //    await _emailNotifyService.SendEmailByHTMLAsync(emailRequest);
                //});
                // thông báo tới các admission officer
                // List<Account> accounts = await _accountService.GetAO(registerAdmissionProfileDTO.CampusId);
                //_ = Task.Run(async () =>
                //{
                //    foreach (var item in accounts)
                //    {
                //        var emailRequest = new EmailRequest
                //        {
                //            ToEmail = item.Email,
                //            Subject = "Học sinh " + registerAdmissionProfileDTO.Fullname + " đã nộp hồ sơ thành công!",
                //            Body = $@"<!DOCTYPE html>
                //                    <html lang=""en"">
                //                    <head>
                //                        <meta charset=""UTF-8"">
                //                        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                //                        <title>Thông tin Đăng ký Tuyển sinh</title>
                //                        <style>
                //                            body {{  
                //                                font-family: Arial, sans-serif;
                //                                line-height: 1.6;
                //                                margin: 20px;
                //                            }}
                //                            .container {{
                //                                max-width: 800px;
                //                                margin: 0 auto;
                //                                border: 1px solid #ddd;
                //                                border-radius: 10px;
                //                                padding: 20px;
                //                                background-color: #f9f9f9;
                //                            }}
                //                            h1 {{
                //                                text-align: center;
                //                                color: #333;
                //                            }}

                //                        </style>
                //                    </head>
                //                    <body>
                //                        <div class=""container"">
                //                            <h1 style=""color: orange"">Thông tin tuyển sinh</h1>
                //                            <p>Hồ sơ của thí sinh {registerAdmissionProfileDTO.Fullname} đã đăng ký thành công vui lòng kiểm tra và phản hồi trong thời gian sớm nhất
                //                            <p>Trân trọng,</p>
                //                            <p>Hệ thống tuyển sinh</p>
                //                        </div>
                //                    </body>
                //                    </html>"
                //        };

                //        await _emailService.SendEmailByHTMLAsync(emailRequest);
                //        RequestNotification requestNotification = new RequestNotification()
                //        {
                //            SendTo = item.Id,
                //            Content = "Hồ sơ đăng ký mới",
                //            Subject = "Học sinh " + registerAdmissionProfileDTO.Fullname + " đăng ký thành công!",
                //            TimeSend = DateTime.Now
                //        };
                //        _requestNotificationService.AddNewRequest(requestNotification);
                //    }
                //});

                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Đăng ký thành công!"
                });
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



        [HttpPut("update-register-admission")]
        public async Task<IActionResult> UpdateAdmissionProfile([FromBody] RegisterAdmissionProfileDTO_Update registerAdmissionProfileDTO)
        {
            try
            {
                StudentProfile studentProfile = await _studentProfileService.GetStudentProfileBySpCIIdAsync(registerAdmissionProfileDTO.CitizenIentificationNumber);
                if (studentProfile == null)
                {
                    return NotFound(new ResponseViewModel { Status = false, Message = "Student profile not found." });
                }
                _mapper.Map(registerAdmissionProfileDTO, studentProfile);

                //add new
                await _studentProfileService.UpdateStudentRegister(studentProfile);
                _ = Task.Run(async () =>
                {

                    var Body = $@"<!DOCTYPE html>
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
                        <h1 style=""color: orange"">Thông tin đăng ký Tuyển sinh</h1>
                        <p>Thân gửi bạn 
                            <strong>{registerAdmissionProfileDTO.Fullname},</strong>
                        </p>
                        <p>Chúng tôi rất vui vì nhận được sự quan tâm từ bạn. 

                        <p>Hồ sơ của bạn đã được cập nhật thành công! Chúng tôi sẽ phản hồi hồ sơ trong thời gian sớm nhất</p>
                        <p>Trân trọng,</p>
                        <p>Phòng Tuyển sinh</p>
                    </div>
                </body>
                </html>";
                    var emailRequest = new EmailRequestNotify
                    {
                        ToEmail = registerAdmissionProfileDTO.EmailStudent,
                        Subject = "Thông báo chỉnh sửa hồ sơ tuyển sinh thành công!",
                        Body = Body,
                    };

                    await _emailNotifyService.SendEmailByHTMLAsync(emailRequest);
                });

                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "chỉnh sửa thành công!"
                });
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
        [Authorize(Roles = "guest")]
        [HttpPost("search-register-admission")]
        public async Task<IActionResult> SearchRegisterAdmission([FromBody] RequestSearchRegisterAdmissionProfileDTO requestSearchRegisterAdmissionProfileDTO)
        {
            try
            {
                if (requestSearchRegisterAdmissionProfileDTO.CitizenIentificationNumber == null) throw new Exception("Không được để trống số căn cước công dân!");
                if (!_userInput.IsValidCCCD(requestSearchRegisterAdmissionProfileDTO.CitizenIentificationNumber)) throw new Exception("Định dạng số căn cước công dân không đúng!");
                bool checkCitizenIentificationNumber = await _studentProfileService.isExistCCCDStudent(requestSearchRegisterAdmissionProfileDTO.CitizenIentificationNumber);
                if (checkCitizenIentificationNumber == true)
                    throw new Exception("Không tìm thấy hồ sơ xét tuyển!");
                StudentProfile stf = await _studentProfileService.GetExistCCCDStudent(requestSearchRegisterAdmissionProfileDTO.CitizenIentificationNumber);
                //mapper
                AdmissionProfile_DTO studentProfile = _mapper.Map<AdmissionProfile_DTO>(stf);
                var payFeeAdmission = stf.PayFeeAdmissions.FirstOrDefault(x => x.isFeeRegister == true);
                studentProfile.PayFeeAdmission = _mapper.Map<PayFeeAdmissionDTO>(payFeeAdmission);

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
        //[Authorize(Roles = "guest")]
        [HttpPost("pay-register-admission")]
        public async Task<IActionResult> PayRegisterAdmission([FromBody] PayFeeAdmissionDTO payFeeAdmissionDTO)
        {
            try
            {
                if (payFeeAdmissionDTO.TransactionStatus != "00")
                {
                    return BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Vui lòng hoàn thành khoản thanh toán!"
                    });
                }
                StudentProfile stf = await _studentProfileService.GetStudentProfileBySpIdAsync(payFeeAdmissionDTO.SpId);
                stf.TypeofStatusProfile = TypeofStatus.SuccessProfileRegister;
                stf.TypeofStatusMajor1 = TypeofStatusForMajor.Inprocess;
                stf.TypeofStatusMajor2 = TypeofStatusForMajor.Inprocess;
                PayFeeAdmission PayFeeAdmission = _mapper.Map<PayFeeAdmission>(payFeeAdmissionDTO);
                await _payFeeAdmissionService.AddNewPayFeeAdmission(PayFeeAdmission);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Thanh toán thành công!"
                });
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
        [HttpPost("send-OTP")]
        public async Task<IActionResult> SendOTPByEmail([FromBody] RequestSendOTP requestSendOTP)
        {
            if (requestSendOTP.CitizenIentificationNumber == null) throw new Exception("Không được để trống số căn cước công dân!");
            if (!_userInput.IsValidCCCD(requestSendOTP.CitizenIentificationNumber)) throw new Exception("Định dạng số căn cước công dân không đúng!");
            bool checkCitizenIentificationNumber = await _studentProfileService.isExistCCCDStudent(requestSendOTP.CitizenIentificationNumber);
            if (checkCitizenIentificationNumber == true)

                throw new Exception("Không tìm thấy hồ sơ xét tuyển!");
            //get profile
            StudentProfile sp = await _studentProfileService.GetStudentProfileBySpCIIdAsync(requestSendOTP.CitizenIentificationNumber);
            if (sp == null || string.IsNullOrEmpty(sp.EmailStudent))
            {
                return BadRequest("Không nhận được email của học sinh!");
            }
            var otp = new Random().Next(100000, 999999).ToString();
            EmailRequest emailRequest = new EmailRequest();
            emailRequest.ToEmail = sp.EmailStudent;
            emailRequest.Subject = "Send OTP";
            emailRequest.Body = $"OTP của bạn là: {otp}";
            _cache.Set(emailRequest.ToEmail, otp, _otpLifetime);
            await _emailNotifyService.SendEmailAsync(emailRequest);
            return Ok(new { Message = "Mã OTP đã được gửi đến email của bạn!", Email = sp.EmailStudent });
        }
        [HttpPost("verify-OTP")]
        public async Task<ActionResult<string>> VerifyOtpAsync(string email, string otp)
        {
            if (_cache.TryGetValue(email, out string storedOtp) && storedOtp == otp)
            {
                _cache.Remove(email);

                var token = _tokenHealper.GenerateAccessToken(email);

                return Ok(new { Token = token });
            }

            return Unauthorized("OTP không hợp lệ.");
        }
        [HttpGet("check-slot-profile-admission")]
        public async Task<IActionResult> CountProfile(string major, string campus)
        {
            try
            {

                int countProfile = await _studentProfileService.CountAdmissionMajor(major, campus);
                var majorTarget = await _majorService.GetMajorDetail(major, campus);
                if (countProfile == majorTarget.Target)
                {
                    return BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Số lượng hồ sơ đã đủ!"
                    });
                }

                return Ok();

            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = "Server lỗi!"
                });
            }
        }
        [HttpGet("check-cccd")]
        public async Task<IActionResult> CheckCCCD(string CCCD)
        {
            if (string.IsNullOrEmpty(CCCD))
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Không được để trống số căn cước công dân!"
                });
            }

            if (!_userInput.IsValidCCCD(CCCD))
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Định dạng số căn cước công dân không đúng!"
                });
            }

            bool isCCCDExists = await _studentProfileService.isExistCCCDStudent(CCCD);
            if (!isCCCDExists)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Căn cước công dân đã tồn tại!"
                });
            }

            try
            {
                return Ok(new ResponseViewModel
                {
                    Status = true,
                    Message = "Số căn cước công dân hợp lệ!"
                });
            }
            catch (Exception ex)
            {
                // Add logging here if necessary
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Server lỗi!"
                });
            }
        }



        [HttpGet("check-email")]
        public async Task<IActionResult> CheckEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Không được để trống email của học sinh!"
                });
            }

            if (!_userInput.IsValidEmail(email))
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Email học sinh không hợp lệ!"
                });
            }

            bool isEmailExists = await _studentProfileService.isExistEmailStudent(email);
            if (!isEmailExists)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Email đã được đăng ký!"
                });
            }

            try
            {
                return Ok(new ResponseViewModel
                {
                    Status = true,
                    Message = "Email hợp lệ!"
                });
            }
            catch (Exception ex)
            {
                // Add logging here if necessary
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Server lỗi!",
                    // Optionally add detailed exception info for development/debug builds
                });
            }
        }


        [HttpGet("check-phone")]
        public async Task<IActionResult> CheckPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Không được để trống số điện thoại của học sinh!"
                });
            }

            if (!_userInput.IsValidPhoneNumber(phone))
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Số điện thoại học sinh không hợp lệ!"
                });
            }

            bool isPhoneExists = await _studentProfileService.isExistPhoneNumberStudent(phone);
            if (!isPhoneExists)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Số điện thoại đã được đăng ký!"
                });
            }

            try
            {
                return Ok(new ResponseViewModel
                {
                    Status = true,
                    Message = "Số điện thoại hợp lệ!"
                });
            }
            catch (Exception ex)
            {
                // Add logging here if necessary
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Server lỗi!"
                });
            }
        }


    }
}
