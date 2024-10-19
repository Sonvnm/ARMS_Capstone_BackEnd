using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.BlogSer;
using Service.MajorSer;

namespace ARMS_API.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
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
        [HttpGet("get-majors")]
        public async Task<IActionResult> GetMajors(string campus)
        {
            try
            {

                List<Major> response = await _majorService.GetMajorsAdmin(campus);

                List<Major_Admin_DTO> responeResult = _mapper.Map<List<Major_Admin_DTO>>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpPost("add-major")]
        public async Task<IActionResult> AddMajor([FromBody] Major_Manage_DTO MajorDTO)
        {
            try
            {
                //check data
                _validMajor.InputMajor(MajorDTO);
                //mapper
                Major major = _mapper.Map<Major>(MajorDTO);
                //add new
                await _majorService.AddNewMajor(major);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Tạo mới mới thành công!"
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
        [HttpPut("update-major")]
        public async Task<IActionResult> UpdateMajor(Major_Manage_DTO MajorDTO)
        {
            try
            {
                //check data
                _validMajor.InputMajor(MajorDTO);
                //mapper
                Major major = _mapper.Map<Major>(MajorDTO);
                await _majorService.UpdateMajor(major);
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
        [HttpGet("get-major-details")]
        public async Task<IActionResult> GetMajorDetail(string MajorId)
        {
            try
            {

                Major response = await _majorService.GetMajorDetail(MajorId);
                Major_Admin_DTO responeResult = _mapper.Map<Major_Admin_DTO>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
