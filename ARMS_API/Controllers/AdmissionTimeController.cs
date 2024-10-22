using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmissionTimeController : Controller
    {
        private IAdmissionTimeService _admissionTimeService;
        private readonly IMapper _mapper;
        public AdmissionTimeController()
        {

        }
        [HttpGet("get-admission-time")]
        public async Task<IActionResult> GetAdmissionTimes()
        {
            return Ok();
        }
    }
}
