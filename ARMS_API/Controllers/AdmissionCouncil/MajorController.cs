using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.MajorSer;

namespace ARMS_API.Controllers.AdmissionCouncil
{
    [Route("api/admission-council/[controller]")]
    [ApiController]
    [Authorize(Roles = "AdmissionCouncil")]
    public class MajorController : ControllerBase
    {

        private IMajorService _majorService;
        private ValidMajor _validMajor;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public MajorController(IMajorService majorService, IMapper mapper, ValidMajor validMajor, UserInput userInput)
        {
            _majorService = majorService;
            _mapper = mapper;
            _validMajor = validMajor;
            _userInput = userInput;
        }
        [HttpPut("update-major")]
        public async Task<IActionResult> UpdateMajor(Major_Admission_DTO MajorDTO)
        {
            try
            {
                MajorAdmission major = _mapper.Map<MajorAdmission>(MajorDTO);
                await _majorService.UpdateMajorAdmission(major);
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
        [HttpGet("get-majors")]
        public async Task<IActionResult> GetMajors(string? CampusId, bool? college, string? Search, int CurrentPage)
        {
            try
            {
                ResponeModel<MajorDTO> result = new ResponeModel<MajorDTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                List<MajorAdmission> response = await _majorService.GetMajorsManage(CampusId);
                if (college != null)
                {
                    response = response.Where(x => x.Major.isVocationalSchool == true).ToList();
                }
                // Search
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(major =>
                                    major != null &&
                                    (
                                        _userInput.NormalizeText(major.Major.MajorName ?? "").Contains(searchTerm) ||
                                        _userInput.NormalizeText(major.Major.MajorCode ?? "").Contains(searchTerm) ||
                                        _userInput.NormalizeText(major.MajorID ?? "").Contains(searchTerm)
                                    )
                                )
                                .ToList();
                }

                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var majors = response
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();

                List<MajorDTO> responeResult = _mapper.Map<List<MajorDTO>>(majors);
                result.Item = responeResult;
                result.TotalItems = response.Count;

                return Ok(result);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpGet("get-major-details")]
        public async Task<IActionResult> GetMajorDetail(string MajorId)
        {
            try
            {

                MajorAdmission response = await _majorService.GetMajorDetail(MajorId);
                MajorDTO responeResult = _mapper.Map<MajorDTO>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpGet("get-majors_admission/{ATId}")]
        public async Task<IActionResult> GetMajorAdmissions(int ATId)
        {
            try
            {

                List<MajorAdmission> response = await _majorService.GetMajorAdmissionsByATId(ATId);
                List<Major_AC_DTO> responeResult = _mapper.Map<List<Major_AC_DTO>>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpGet("get-majors_admission_and_register/{ATId}")]
        public async Task<IActionResult> GetMajorAdmissionsAndRegister(int ATId)
        {
            try
            {

                List<object> response = await _majorService.GetMajorAdmissionsAndRegisterByATId(ATId);
                return Ok(response);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpGet("get-majors_admission_and_register")]
        public async Task<IActionResult> GetMajorAdmissionsAndRegisterProcess(string CampusId)
        {
            try
            {
                List<object> response = await _majorService.GetMajorAdmissionsAndRegisterProcess(CampusId);
                return Ok(response);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
