using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.MajorSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARMS_API.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class MajorController : ControllerBase
    {
        private readonly IMajorService _majorService;
        private readonly IMapper _mapper;
        private readonly ILogger<MajorController> _logger;

        public MajorController(IMajorService majorService, IMapper mapper, ILogger<MajorController> logger)
        {
            _majorService = majorService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("get-majors")]
        public async Task<IActionResult> GetMajors(string campus)
        {
            try
            {
                var majors = await _majorService.GetMajors(campus);
                var response = _mapper.Map<List<Major_Admin_DTO>>(majors);

                return Ok(new ApiResponse<List<Major_Admin_DTO>>
                {
                    Status = true,
                    Message = "Danh sách ngành đã được lấy thành công!",
                    Data = response
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching majors for campus {Campus}", campus);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<string>
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi khi lấy danh sách ngành!"
                });
            }
        }

        [HttpPost("add-major")]
        public async Task<IActionResult> AddMajor([FromBody] Major_Manage_DTO majorDTO, [FromServices] IValidator<Major_Manage_DTO> validator)
        {
            try
            {
                var validationResult = await validator.ValidateAsync(majorDTO);
                if (!validationResult.IsValid)
                {
                    return BadRequest(new ApiResponse<string>
                    {
                        Status = false,
                        Message = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage))
                    });
                }

                var major = _mapper.Map<Major>(majorDTO);
                await _majorService.AddNewMajor(major);

                return Ok(new ApiResponse<string>
                {
                    Status = true,
                    Message = "Tạo mới ngành thành công!"
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while adding a new major.");
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<string>
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi khi tạo mới ngành!"
                });
            }
        }

        [HttpPut("update-major")]
        public async Task<IActionResult> UpdateMajor([FromBody] Major_Manage_DTO majorDTO, [FromServices] IValidator<Major_Manage_DTO> validator)
        {
            try
            {
                var validationResult = await validator.ValidateAsync(majorDTO);
                if (!validationResult.IsValid)
                {
                    return BadRequest(new ApiResponse<string>
                    {
                        Status = false,
                        Message = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage))
                    });
                }

                var major = _mapper.Map<Major>(majorDTO);
                await _majorService.UpdateMajor(major);

                return Ok(new ApiResponse<string>
                {
                    Status = true,
                    Message = "Cập nhật ngành thành công!"
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while updating a major.");
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<string>
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi khi cập nhật ngành!"
                });
            }
        }

        [HttpGet("get-major-details")]
        public async Task<IActionResult> GetMajorDetail(string majorId)
        {
            try
            {
                var major = await _majorService.GetMajor(majorId);
                if (major == null)
                {
                    return NotFound(new ApiResponse<string>
                    {
                        Status = false,
                        Message = "Ngành không tồn tại!"
                    });
                }

                var response = _mapper.Map<Major_Admin_DTO>(major);
                return Ok(new ApiResponse<Major_Admin_DTO>
                {
                    Status = true,
                    Message = "Chi tiết ngành đã được lấy thành công!",
                    Data = response
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching details for major {MajorId}", majorId);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<string>
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi khi lấy chi tiết ngành!"
                });
            }
        }

        // Generic response wrapper class for API responses
        public class ApiResponse<T>
        {
            public bool Status { get; set; }
            public string Message { get; set; }
            public T Data { get; set; }
        }
    }
}
