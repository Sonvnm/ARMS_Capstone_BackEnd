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
        public MajorController(IMajorService majorService, IMapper mapper, ValidMajor validMajor)
        {
            _majorService = majorService;
            _mapper = mapper;
            _validMajor = validMajor;
        }
        [HttpPut("update-major")]
        public async Task<IActionResult> UpdateMajor(Major_Admission_DTO MajorDTO)
        {
            try
            {
                Major major = _mapper.Map<Major>(MajorDTO);
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
        public async Task<IActionResult> GetMajors(string campus)
        {
            try
            {

                List<Major> response = await _majorService.GetMajorsAdmin(campus);

                List<Major_Admission_Council_DTO> responeResult = _mapper.Map<List<Major_Admission_Council_DTO>>(response);
                return Ok(responeResult);

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

                Major response = await _majorService.GetMajorDetail(MajorId);
                Major_Admission_Council_DTO responeResult = _mapper.Map<Major_Admission_Council_DTO>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
