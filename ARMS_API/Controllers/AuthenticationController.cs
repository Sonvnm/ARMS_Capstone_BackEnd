using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
        [HttpPost("gg/login-with-google")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginWithGoogle()
        {
            return Ok();
        }

    }
}
