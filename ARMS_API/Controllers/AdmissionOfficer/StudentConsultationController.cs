using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Service.StudentConsultationSer;

namespace ARMS_API.Controllers.AdmissionOfficer
{
    [Route("api/admin-officer/[controller]")]

    [ApiController]
    [Authorize(Roles = "AdminOfficer")]
    public class StudentConsultationController : ControllerBase
    {
        private IStudentConsultationService _studentConsultationService;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        private ValidStudentConsultation _validInput;
        public StudentConsultationController(IStudentConsultationService studentConsultationService, IMapper mapper, ValidStudentConsultation validInput, UserInput userInput)
        {
            _studentConsultationService = studentConsultationService;
            _mapper = mapper;
            _validInput = validInput;
            _userInput = userInput;
        }
        [HttpGet("get-list-student-consultation")]
        public async Task<IActionResult> GetStudentConsultation(string CampusId, string? Search, int CurrentPage, bool? isVocationalSchool, StatusConsultation? Status)
        {
            try
            {
                ResponeModel<StudentConsultation_AO_DTO> result = new ResponeModel<StudentConsultation_AO_DTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                List<StudentConsultation> response = await _studentConsultationService.GetListStudentConsultation(CampusId);
                // Search
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(sc =>
                                    _userInput.NormalizeText(sc.FullName ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sc.Email ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sc.Notes ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sc.LinkFB ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sc.Major?.MajorName ?? "").Contains(searchTerm)
                                )
                                .ToList();
                }

                if (isVocationalSchool != null)
                {
                    response = response.Where(x => x.Major.isVocationalSchool == isVocationalSchool).ToList();
                }
                if (Status != null)
                {
                    response = response.Where(x => x.Status == Status).ToList();
                }

                // Paging
                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var blogs = response
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();

                // Map to StudentConsultation_AO_DTO

                List<StudentConsultation_AO_DTO> responeResult = _mapper.Map<List<StudentConsultation_AO_DTO>>(response);
                result.Item = responeResult;

                
                return Ok(result);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpPut("update-student-consultation")]
        public async Task<IActionResult> UpdateStudentConsultation(StudentConsultation_AO_DTO StudentConsultationDTO)
        {
            try
            {
                _validInput.UpdateStudentConsultation(StudentConsultationDTO);
                StudentConsultation responeResult = _mapper.Map<StudentConsultation>(StudentConsultationDTO);
                await _studentConsultationService.UpdateStudentConsultation(responeResult);

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
        [HttpPost]
        public async Task<IActionResult> AddStudentConsultation([FromBody] List<StudentConsultationDTO> studentConsultationDTOs)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            var invalidObjects = new List<object>(); // Lưu các object bị lỗi
            var validObjects = new List<StudentConsultationDTO>(); // Lưu các object hợp lệ

            foreach (var dto in studentConsultationDTOs)
            {
                try
                {
                    // Kiểm tra dữ liệu
                    _validInput.InputStudentConsultation(dto);

                    // Nếu không có lỗi, thêm vào danh sách hợp lệ
                    validObjects.Add(dto);
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi, thêm vào danh sách không hợp lệ với thông báo lỗi
                    invalidObjects.Add(new
                    {
                        Data = dto,
                        Error = ex.Message
                    });
                }
            }

            // Xử lý các object hợp lệ
            foreach (var validDto in validObjects)
            {
                var studentConsultation = _mapper.Map<StudentConsultation>(validDto);
                studentConsultation.StudentConsultationId = Guid.NewGuid();
                studentConsultation.Status = StatusConsultation.Reception;
                studentConsultation.DateReceive = DateTime.Now;
                studentConsultation.CreateBy = Guid.Parse(userId);
                await _studentConsultationService.AddNewStudentConsultation(studentConsultation);
            }

            // Trả về kết quả
            return Ok(new
            {
                Status = true,
                Message = "Xử lý hoàn tất!",
                TotalProcessed = validObjects.Count,
                TotalErrors = invalidObjects.Count,
                InvalidObjects = invalidObjects
            });
        }
        [HttpGet("download-template")]
        public IActionResult DownloadTemplate()
        {
            try
            {
                // Tính đường dẫn từ thư mục gốc của ứng dụng
                var rootPath = Directory.GetCurrentDirectory(); // Gốc của dự án
                var filePath = Path.Combine(rootPath, "File", "Đăng ký tư vấn.xlsx");

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound(new { message = "Không tìm thấy file." });
                }

                var fileBytes = System.IO.File.ReadAllBytes(filePath);
                return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Đăng ký tư vấn.xlsx");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Đã xảy ra lỗi khi tải file.", details = ex.Message });
            }
        }
        [HttpPost("upload-excel")]
        public async Task<IActionResult> AddStudentConsultationFromExcel([FromForm] IFormFile file)
        {
            var campusIds = new[] { "Hà Nội", "Hồ Chí Minh", "Cần Thơ", "Thanh Hóa", "Đà Nẵng" };

            if (file == null || file.Length == 0)
            {
                return BadRequest(new { Status = false, Message = "Không tìm thấy tệp tin hoặc tệp tin rỗng!" });
            }

            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Status = false, Message = "Người dùng không xác thực!" });
            }

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using var package = new ExcelPackage(file.OpenReadStream());

                if (package.Workbook.Worksheets.Count == 0)
                {
                    return BadRequest(new { Status = false, Message = "Tệp Excel không có sheet nào!" });
                }

                var worksheet = package.Workbook.Worksheets[0];
                if (worksheet?.Dimension == null)
                {
                    return BadRequest(new { Status = false, Message = "Sheet đầu tiên trong tệp Excel trống!" });
                }

                var invalidObjects = new List<dynamic>();
                var validObjects = new List<StudentConsultationDTO>();

                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    try
                    {
                        var fullName = worksheet.Cells[row, 1]?.Text?.Trim();
                        var phoneNumber = worksheet.Cells[row, 2]?.Text?.Trim();
                        var email = worksheet.Cells[row, 3]?.Text?.Trim();
                        var majorId = worksheet.Cells[row, 4]?.Text?.Trim();
                        var linkFb = worksheet.Cells[row, 5]?.Text?.Trim();
                        var campusId = GetCampusId(worksheet.Cells[row, 6]?.Text?.Trim());



                        var dto = new StudentConsultationDTO
                        {
                            FullName = fullName,
                            PhoneNumber = phoneNumber,
                            Email = email,
                            MajorID = majorId,
                            LinkFB = linkFb,
                            CampusId = campusId
                        };
                        _validInput.InputStudentConsultation(dto);
                        validObjects.Add(dto);
                    }
                    catch (Exception ex)
                    {
                        invalidObjects.Add(new
                        {
                            Row = row,
                            FullName = worksheet.Cells[row, 1]?.Text,
                            PhoneNumber = worksheet.Cells[row, 2]?.Text,
                            Email = worksheet.Cells[row, 3]?.Text,
                            MajorID = worksheet.Cells[row, 4]?.Text,
                            LinkFB = worksheet.Cells[row, 5]?.Text,
                            CampusId = worksheet.Cells[row, 6]?.Text,
                            Error = ex.Message
                        });

                        Console.WriteLine($"Error in row {row}: {ex.Message}");
                    }

                }

                foreach (var validDto in validObjects)
                {
                    var studentConsultation = _mapper.Map<StudentConsultation>(validDto);
                    studentConsultation.StudentConsultationId = Guid.NewGuid();
                    studentConsultation.Status = StatusConsultation.Reception;
                    studentConsultation.DateReceive = DateTime.UtcNow;
                    studentConsultation.CreateBy = Guid.Parse(userId);
                    await _studentConsultationService.AddNewStudentConsultation(studentConsultation);
                }

                if (invalidObjects.Count > 0)
                {
                    Console.WriteLine(invalidObjects.Count);
                    using var errorPackage = new ExcelPackage();
                    var errorSheet = errorPackage.Workbook.Worksheets.Add("Invalid Data");

                    // Sửa header theo yêu cầu
                    errorSheet.Cells[1, 1].Value = "Họ và tên";
                    errorSheet.Cells[1, 2].Value = "Số điện thoại";
                    errorSheet.Cells[1, 3].Value = "Email";
                    errorSheet.Cells[1, 4].Value = "Ngành học";
                    errorSheet.Cells[1, 5].Value = "Link facebook";
                    errorSheet.Cells[1, 6].Value = "Cơ sở";
                    errorSheet.Cells[1, 7].Value = "Lỗi";

                    // Ghi dữ liệu vào file
                    for (int i = 0; i < invalidObjects.Count; i++)
                    {
                        var error = invalidObjects[i];
                        errorSheet.Cells[i + 2, 1].Value = error.FullName;
                        errorSheet.Cells[i + 2, 2].Value = error.PhoneNumber;
                        errorSheet.Cells[i + 2, 3].Value = error.Email;
                        errorSheet.Cells[i + 2, 4].Value = error.MajorID;
                        errorSheet.Cells[i + 2, 5].Value = error.LinkFB;
                        var campusCell = errorSheet.Cells[i + 2, 6];
                        errorSheet.Cells[i + 2, 7].Value = error.Error;

                        var campusRange = string.Join(",", campusIds);
                        var validation = campusCell.DataValidation.AddListDataValidation();
                        validation.Formula.Values.Add(campusRange);

                        var campusIdsList = campusIds.ToList();
                        campusCell.Value = error.CampusId;

                    }

                    var errorFileContent = errorPackage.GetAsByteArray();
                    var fileName = $"Errors.xlsx";
                    return File(errorFileContent, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);

                }
                else
                {
                    return Ok(new
                    {
                        Status = true,
                        Message = "Xử lý hoàn tất!",
                        TotalProcessed = validObjects.Count,
                        TotalErrors = invalidObjects.Count
                    });

                }


            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Status = false,
                    Message = "Có lỗi xảy ra trong quá trình xử lý tệp",
                    Error = ex.Message
                });
            }
        }



        private string GetCampusId(string campusName)
        {
            if (string.IsNullOrWhiteSpace(campusName))
            {
                throw new ArgumentException("Tên cơ sở không được để trống.");
            }

            var campusMapping = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Hà Nội", "Hanoi" },
                { "Hồ Chí Minh", "HCM" },
                { "Cần Thơ", "Cantho" },
                { "Thanh Hóa", "Thanhhoa" },
                { "Đà Nẵng", "Danang" }
            };

            if (campusMapping.TryGetValue(campusName.Trim(), out var campusId))
            {
                return campusId;
            }

            throw new ArgumentException($"Không tìm thấy cơ sở có tên: {campusName}");
        }
    }
}
