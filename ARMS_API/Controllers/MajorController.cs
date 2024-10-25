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
                List<MajorAdmission> data = await _majorService.GetMajorsIsVocationalSchool(campus);
                if (data == null || !data.Any())
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không có ngành trung cấp nào đang tuyển!"
                    });
                }
                List<MajorDTO> result = _mapper.Map<List<MajorDTO>>(data);
                return Ok(result);
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
                List<MajorAdmission> majorList = await _majorService.GetMajorsIsCollege(campus);
                if (majorList == null)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không có ngành cao đẳng nào đang tuyển!"
                    });
                }
                List<MajorDTO> dtoResult = _mapper.Map<List<MajorDTO>>(majorList);
                return Ok(dtoResult);
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
                List<MajorAdmission> majors = await _majorService.GetMajorsIsCollegeForVocationalSchool(campus);
                if (majors == null || majors.Count == 0)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không có ngành xét tuyển liên thông nào!"
                    });
                }
                List<MajorDTO> mappedMajors = _mapper.Map<List<MajorDTO>>(majors);
                return Ok(mappedMajors);
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
        public async Task<IActionResult> GetMajorDetail(string MajorId)
        {
            try
            {
                MajorAdmission majorData = await _majorService.GetMajorDetail(MajorId);
                if (string.IsNullOrEmpty(MajorId) || majorData == null)
                {
                    return NotFound(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không tìm thấy ngành học!"
                    });
                }
                MajorDTO majorDetail = _mapper.Map<MajorDTO>(majorData);
                return Ok(majorDetail);
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
