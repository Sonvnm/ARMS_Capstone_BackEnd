using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.MajorRepo;
using Service.MajorSer;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MajorController : ControllerBase
    {
        private IMajorService _majorService;
        private readonly IMapper _mapper;
        public MajorController(IMajorService majorService, IMapper mapper)
        {
            _majorService = majorService;
            _mapper = mapper;
        }
        [HttpGet("get-majors-vocational-school")]
        public async Task<IActionResult> GetMajorsVocationalSchool(string campus)
        {
            try
            {

                List<MajorAdmission> response = await _majorService.GetMajorsIsVocationalSchool(campus);

                List<MajorDTO> responeResult = _mapper.Map<List<MajorDTO>>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpGet("get-majors-college")]
        public async Task<IActionResult> GetMajorsCollege(string campus)
        {
            try
            {

                List<MajorAdmission> response = await _majorService.GetMajorsIsCollege(campus);

                List<MajorDTO> responeResult = _mapper.Map<List<MajorDTO>>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpGet("get-major-details")]
        public async Task<IActionResult> GetMajorDetail(string MajorId, int AdmissionInformationID)
        {
            try
            {

                MajorAdmission response = await _majorService.GetMajorDetail(MajorId,AdmissionInformationID);
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
