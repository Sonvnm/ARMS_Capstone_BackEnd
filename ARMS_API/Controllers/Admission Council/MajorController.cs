using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.MajorSer;
using System.Text.Json;

namespace ARMS_API.Controllers.AdmissionCouncil
{
    [Route("api/admission-council/[controller]")]
    [ApiController]
    [Authorize(Roles = "AdmissionCouncil")]
    public class MajorController : ControllerBase
    {
        private readonly IMajorService _majorService;
        private readonly ValidMajor _validMajor;
        private readonly IMapper _mapper;
        private readonly UserInput _userInput;

        public MajorController(IMajorService majorService, IMapper mapper, ValidMajor validMajor, UserInput userInput)
        {
            _majorService = majorService;
            _mapper = mapper;
            _validMajor = validMajor;
            _userInput = userInput;
        }

        [HttpPut("update-major")]
        public async Task<IActionResult> UpdateMajor([FromBody] Major_Admission_DTO majorDTO)
        {
            try
            {
                // Validate input
                _validMajor.ValidateMajorInput(majorDTO);

                // Map DTO to entity
                var major = _mapper.Map<MajorAdmission>(majorDTO);

                // Update major
                await _majorService.UpdateMajorAdmission(major);

                return Ok(new ApiResponse<string>(true, "Cập nhật thành công!"));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<string>(false, "Cập nhật thất bại.", ex.Message));
            }
        }

        [HttpPost("add-major")]
        public async Task<IActionResult> AddMajor([FromBody] Major_Admission_DTO majorDTO)
        {
            try
            {
                // Validate input
                _validMajor.ValidateMajorInput(majorDTO);

                // Map DTO to entity
                var major = _mapper.Map<MajorAdmission>(majorDTO);

                // Add new major
                await _majorService.AddMajorAdmission(major);

                return Ok(new ApiResponse<string>(true, "Thêm ngành tuyển sinh thành công!"));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<string>(false, "Thêm ngành thất bại.", ex.Message));
            }
        }

        [HttpGet("get-majors")]
        public async Task<IActionResult> GetMajors(string? campusId, bool? college, string? search, int currentPage)
        {
            try
            {
                var responseModel = new ResponeModel<MajorDTO>
                {
                    CurrentPage = currentPage,
                    CampusId = campusId,
                    Search = search
                };

                // Retrieve majors
                var majors = await _majorService.GetMajorsManage(campusId);

                // Filter by college
                if (college == true)
                {
                    majors = majors.Where(m => m.Major.isVocationalSchool == true).ToList();
                }

                // Search functionality
                if (!string.IsNullOrWhiteSpace(search))
                {
                    var normalizedSearch = _userInput.NormalizeText(search);
                    majors = majors.Where(m =>
                        m != null &&
                        (
                            _userInput.NormalizeText(m.Major.MajorName ?? string.Empty).Contains(normalizedSearch) ||
                            _userInput.NormalizeText(m.Major.MajorCode ?? string.Empty).Contains(normalizedSearch) ||
                            _userInput.NormalizeText(m.MajorID ?? string.Empty).Contains(normalizedSearch)
                        )
                    ).ToList();
                }

                // Pagination
                responseModel.PageCount = (int)Math.Ceiling(majors.Count / (double)responseModel.PageSize);
                var paginatedMajors = majors
                    .Skip((currentPage - 1) * responseModel.PageSize)
                    .Take(responseModel.PageSize)
                    .ToList();

                responseModel.Item = _mapper.Map<List<MajorDTO>>(paginatedMajors);
                responseModel.TotalItems = majors.Count;

                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<string>(false, "Không thể lấy danh sách ngành.", ex.Message));
            }
        }

        [HttpGet("get-major-details")]
        public async Task<IActionResult> GetMajorDetail(string majorId)
        {
            try
            {
                // Retrieve major details
                var major = await _majorService.GetMajorDetail(majorId);
                var response = _mapper.Map<MajorDTO>(major);

                return Ok(new ApiResponse<MajorDTO>(true, "Lấy chi tiết ngành thành công!", response));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<string>(false, "Không thể lấy chi tiết ngành.", ex.Message));
            }
        }

        [HttpGet("get-majors_admission/{atId}")]
        public async Task<IActionResult> GetMajorAdmissions(int atId)
        {
            try
            {
                // Retrieve major admissions
                var majorAdmissions = await _majorService.GetMajorAdmissionsByATId(atId);
                var response = _mapper.Map<List<Major_AC_DTO>>(majorAdmissions);

                return Ok(new ApiResponse<List<Major_AC_DTO>>(true, "Lấy danh sách ngành tuyển sinh thành công!", response));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<string>(false, "Không thể lấy danh sách ngành tuyển sinh.", ex.Message));
            }
        }
    }

    // API Response Wrapper
    public class ApiResponse<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }

        public ApiResponse(bool status, string message, T? data = default)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}
