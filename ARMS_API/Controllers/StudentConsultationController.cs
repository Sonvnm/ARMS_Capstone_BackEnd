using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Repository.MajorRepo;
using Service.StudentConsultationSer;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentConsultationController : ControllerBase
    {
        private IStudentConsultationService _studentConsultationService;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        private ValidStudentConsultation _validInput;
        private readonly UserManager<Account> _userManager;
        public StudentConsultationController(IStudentConsultationService studentConsultationService, IMapper mapper, ValidStudentConsultation validInput, UserInput userInput)
        {
            _studentConsultationService = studentConsultationService;
            _mapper = mapper;
            _validInput = validInput;
            _userInput = userInput;
        }
        [HttpPost]
        public async Task<IActionResult> AddStudentConsultation([FromBody] StudentConsultationDTO studentConsultationDTO)
        {
            try
            {
                // check data
                _validInput.InputStudentConsultation(studentConsultationDTO);
                //mapper
                StudentConsultation studentConsultation = _mapper.Map<StudentConsultation>(studentConsultationDTO);
                studentConsultation.StudentConsultationId = Guid.NewGuid();
                studentConsultation.Status = StatusConsultation.Reception;
                studentConsultation.DateReceive = DateTime.Now;
                //add new
                await _studentConsultationService.AddNewStudentConsultation(studentConsultation);
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
            if (file == null || file.Length == 0)
            {
                return BadRequest(new { Status = false, Message = "Không tìm thấy tệp tin!" });
            }

            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var user = await _userManager.FindByIdAsync(userId);
            var invalidObjects = new List<object>(); // Lưu các object bị lỗi
            var validObjects = new List<StudentConsultationDTO>(); // Lưu các object hợp lệ

            try
            {
                // Đọc tệp Excel
                using (var package = new ExcelPackage(file.OpenReadStream()))
                {
                    // Giả sử tệp Excel có một sheet đầu tiên
                    var worksheet = package.Workbook.Worksheets[0];

                    // Lặp qua các dòng trong Excel và lấy dữ liệu
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++) // Bắt đầu từ dòng 2 nếu dòng 1 là header
                    {
                        var dto = new StudentConsultationDTO
                        {
                            // Đọc dữ liệu từ các cột trong tệp Excel
                            FullName = worksheet.Cells[row, 1].Text, // Cột 1
                            PhoneNumber = worksheet.Cells[row, 2].Text, // Cột 2
                            Email = worksheet.Cells[row, 3].Text, // Cột 3
                            MajorID = worksheet.Cells[row, 4].Text, // Cột 4
                            LinkFB = worksheet.Cells[row, 5].Text, // Cột 5
                            CampusId = GetCampusId(worksheet.Cells[row, 6].Text), // Cột 6
                        };

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
            catch (Exception ex)
            {
                // Nếu có lỗi trong quá trình đọc tệp hoặc xử lý dữ liệu
                return StatusCode(500, new { Status = false, Message = "Có lỗi xảy ra trong quá trình xử lý tệp", Error = ex.Message });
            }
        }
        private string GetCampusId(string campusName)
        {
            var campusMapping = new Dictionary<string, string>
            {
                { "Hà Nội", "Hanoi" },
                { "Hồ Chí Minh", "HCM" },
                { "Cần Thơ", "Cantho" },
                { "Thanh Hóa", "Thanhhoa" },
                { "Đà Nẵng", "Danang" }
            };

            if (campusMapping.TryGetValue(campusName.Trim(), out var campusId))
            {
                return campusId; // Return the corresponding campus ID
            }

            return null; // Return null if campus name not found
        }

    }
}
