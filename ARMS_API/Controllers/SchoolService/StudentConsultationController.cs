using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.MajorRepo;
using Service.StudentConsultationSer;

namespace ARMS_API.Controllers.SchoolService
{
    [Route("api/SchoolService/[controller]")]
    [ApiController]
    //[Authorize(Roles = "SchoolService")]
    //Thêm tư vấn tuyển sinh cho schoole service ???? ý là School service cũng có thể xem đc tư vấn tuyển sinh
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
        [HttpPost]
        public async Task<IActionResult> AddStudentConsultation([FromBody] List<StudentConsultationDTO> studentConsultationDTOs)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var invalidObjects = new List<object>(); // bắt Object bị lỗi nè
            var validObjects = new List<StudentConsultationDTO>(); // b8t các object hợp lệ

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

            // rồi :3 tèn ten :V
            return Ok(new
            {
                Status = true,
                Message = "Xử lý hoàn tất!",
                TotalProcessed = validObjects.Count,
                TotalErrors = invalidObjects.Count,
                InvalidObjects = invalidObjects
            });
        }
        [HttpGet("get-list-student-consultation")]
        public async Task<IActionResult> GetStudentConsultation(string CampusId, string? Search, int CurrentPage, bool? isVocationalSchool)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                ResponeModel<StudentConsultation_SS_DTO> result = new ResponeModel<StudentConsultation_SS_DTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                List<StudentConsultation> response = await _studentConsultationService.GetListStudentConsultation(CampusId);
                response = response.Where(x => x.CreateBy == Guid.Parse(userId)).ToList();
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

                // Paging
                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var blogs = response
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();

                // Map to StudentConsultation_AO_DTO

                List<StudentConsultation_SS_DTO> responeResult = _mapper.Map<List<StudentConsultation_SS_DTO>>(response);
                result.Item = responeResult;


                return Ok(result);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

    }
}
