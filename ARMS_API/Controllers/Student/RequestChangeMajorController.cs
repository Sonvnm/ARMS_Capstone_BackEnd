using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.BlogSer;
using Service.RequestChangeMajorSer;
using static Google.Apis.Requests.BatchRequest;
namespace ARMS_API.Controllers.Student
{
    [Route("api/Student/[controller]")]
    [ApiController]
    [Authorize(Roles = "Student")]
    public class RequestChangeMajorController : ControllerBase
    {
        private IRequestChangeMajorService _requestChangeMajorService;
        private readonly IMapper _mapper;
        public RequestChangeMajorController(IRequestChangeMajorService requestChangeMajorService, IMapper mapper)
        {
            _requestChangeMajorService = requestChangeMajorService;
            _mapper = mapper;
        }
        [HttpGet("get-request-change-major")]
        public async Task<IActionResult> GetRequestChangeMajor()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized("Không tìm thấy ID người dùng!");
                }
                List<RequestChangeMajor> request = await _requestChangeMajorService.GetRequestChangeMajorsByID(Guid.Parse(userId));
                List<RequestChangeMajorDTO> responeResult = _mapper.Map<List<RequestChangeMajorDTO>>(request);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}