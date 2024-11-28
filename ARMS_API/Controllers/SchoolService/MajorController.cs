using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.MajorRepo;
using Service.MajorSer;
using static Google.Apis.Requests.BatchRequest;

namespace ARMS_API.Controllers.SchoolService
{
    [Route("api/school-service/[controller]")]
    [ApiController]
    //[Authorize(Roles = "SchoolService")]
    public class MajorController : ControllerBase
    {
        private IMajorService _majorService;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public MajorController(IMajorService majorService, IMapper mapper, UserInput userInput)
        {
            _majorService = majorService;
            _mapper = mapper;
            _userInput = userInput;
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
                response = response.Where(x=>x.Status==true).ToList();
                if (college!=null)
                {
                    response = response.Where(x=>x.Major.isVocationalSchool==true).ToList();
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
    }
}
