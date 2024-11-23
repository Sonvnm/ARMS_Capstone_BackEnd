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
