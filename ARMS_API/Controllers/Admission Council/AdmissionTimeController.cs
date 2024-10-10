using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers.Admission_Council
{
    [Route("api/admission-council/[controller]")]
    [ApiController]
    public class AdmissionTimeController : ControllerBase
    {

        [HttpGet("get-admission-time")]
        public async Task<IActionResult> GetAdmissionTimes()
        {
            return Ok();
        }
        [HttpPost("add-admission-time")]
        public async Task<IActionResult> AddAdmissionTime() {  return Ok(); }

        [HttpPut("update-admission-time")]
        public async Task<IActionResult> UpdateAdmissionTime()
        {
            return Ok();
        }
    }
}
