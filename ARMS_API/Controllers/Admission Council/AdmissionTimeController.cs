using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionTimeSer;

namespace ARMS_API.Controllers.Admission_Council
{
    [Route("api/admission-council/[controller]")]
    [ApiController]
    public class AdmissionTimeController : ControllerBase
    {
        private IAdmissionTimeService _admissionTimeService;
        private readonly IMapper _mapper;
        public AdmissionTimeController(IAdmissionTimeService admissionTimeService, IMapper mapper)
        {
            _admissionTimeService = admissionTimeService;
            _mapper = mapper;
            
        }

        public async Task<IActionResult> GetAdmissionTimes(string CampusId, int year)
        {
            try
            {
                List<AdmissionTime> response = await _admissionTimeService.GetAdmissionTimes(CampusId);
                List<AdmissionTime_Admission_DTO> responeResult = _mapper.Map<List<AdmissionTime_Admission_DTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("add-admission-time")]
        public async Task<IActionResult> AddAdmissionTime() {  return Ok(); }

        [HttpPut("update-admission-time")]
        public async Task<IActionResult> UpdateAdmissionTime()
        {
            return Ok();
        }
    }
}
