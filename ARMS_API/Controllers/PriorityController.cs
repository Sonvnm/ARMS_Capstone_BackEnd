using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.MajorSer;
using Service.PriorityService;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriorityController : ControllerBase
    {
        private IPriorityService _priorityService;
        private readonly IMapper _mapper;
        public PriorityController(IPriorityService priorityService, IMapper mapper)
        {
            _priorityService = priorityService;
            _mapper = mapper;
        }
        [HttpGet("get-priority")]
        public async Task<IActionResult> GetPriorities()
        {
            try
            {

                List<PriorityDetail> response = await _priorityService.GetPriorities();

                List<PriorityDTO> responeResult = _mapper.Map<List<PriorityDTO>>(response);
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
