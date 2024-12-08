using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionTimeSer;
using Service.MajorSer;

namespace ARMS_API.Controllers.AdmissionCouncil
{
    [Route("api/admission-council/[controller]")]
    [ApiController]
    //[Authorize(Roles = "AdmissionCouncil")]
    public class AdmissionTimeController : ControllerBase
    {
        private IAdmissionTimeService _admissionTimeService;
        private readonly IMapper _mapper;
        private ValidAdmissionTime _validAdmissionTime;
        public AdmissionTimeController(IAdmissionTimeService admissionTimeService, IMapper mapper, ValidAdmissionTime validAdmissionTime)
        {
            _admissionTimeService = admissionTimeService;
            _mapper = mapper;
            _validAdmissionTime = validAdmissionTime;
        }
        [HttpGet("get-admission-time")]
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
        public async Task<IActionResult> AddAdmissionTime([FromBody] AdmissionTime_Add_DTO admissionTimeDTO)
        {
            try
            {
                //check data
                await _validAdmissionTime.ValidDataAdmissionTime
                    (admissionTimeDTO);
                //mapper
                AdmissionTime AdmissionTime = _mapper.Map<AdmissionTime>(admissionTimeDTO);
                //add new
                await _admissionTimeService.AddAdmissionTime(AdmissionTime);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Tạo mới thành công!"
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
        [HttpPut("update-admission-time")]
        public async Task<IActionResult> UpdateAdmissionTime(AdmissionTime_Add_DTO admissionTimeDTO)
        {
            try
            {
                //check data
                await _validAdmissionTime.ValidDataAdmissionTimeUpdate
                   (admissionTimeDTO);
                //mapper
                AdmissionTime AdmissionTime = _mapper.Map<AdmissionTime>(admissionTimeDTO);
                await _admissionTimeService.UpdateAdmissionTime(AdmissionTime);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
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
        
    }
}
