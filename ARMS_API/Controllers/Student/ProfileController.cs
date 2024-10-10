using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers.Student
{
    public class ProfileController : ControllerBase
    {
        [HttpGet("get-profile")]
        public async Task<IActionResult> GetMajor()
        {
            return Ok();
        }
    }
}
