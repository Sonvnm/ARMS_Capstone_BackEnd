using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers.Admission_Council
{
    public class AdmissionInformationController : ControllerBase
    {
        [HttpGet("get-admission-information")]
        public async Task<IActionResult> GetAdmissionInformation()
        {
            return Ok();
        }
        [HttpGet("get-admission-information-by-id")]
        public async Task<IActionResult> GetAdmissionInformationById()
        {
            return Ok();
        }
        [HttpPost("add-admission-information")]
        public async Task<IActionResult> AddAdmissionTime()
        {
            return Ok();
        }
        [HttpPut("update-admission-information")]
        public async Task<IActionResult> UpdateAdmissionInformation()
        {
            return Ok();
        }

    }
}
