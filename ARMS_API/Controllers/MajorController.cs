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
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
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
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
        [HttpGet("get-majors-college-for-vocational-school")]
        public async Task<IActionResult> GetMajorsCollegeForVocationalSchool(string campus)
        {
            try
            {

                List<MajorAdmission> response = await _majorService.GetMajorsIsCollegeForVocationalSchool(campus);

                List<MajorDTO> responeResult = _mapper.Map<List<MajorDTO>>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
        [HttpGet("get-major-details")]
        public async Task<IActionResult> GetMajorDetail(string MajorId, int AdmissionInformationID)
        {
            try
            {

                MajorAdmission response = await _majorService.GetMajorDetail(MajorId,AdmissionInformationID);
                if (response == null)
                {
                    return NotFound(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không tìm thấy ngành học!"
                    });
                }
                MajorDTO responeResult = _mapper.Map<MajorDTO>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
    }
}
