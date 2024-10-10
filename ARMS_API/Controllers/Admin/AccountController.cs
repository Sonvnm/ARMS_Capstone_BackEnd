using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet("get-accounts")]
        public async Task<IActionResult> GetAccounts()
        {
            return Ok(Ok());
        }
        [HttpGet("get-account/{id}")]
        public async Task<IActionResult> GetAccounts(Guid id)
        {
            return Ok(Ok());
        }
        [HttpGet("reset-password/{id}")]
        public async Task<IActionResult> ResetPassword(Guid id)
        {
            return Ok(Ok());
        }
        [HttpGet("get-accounts-student")]
        public async Task<IActionResult> GetAccountsRequest()
        {
            return Ok(Ok());
        }
        [HttpPost("create-account")]
        public async Task<IActionResult> CreateAccount()
        {
            return Ok(Ok());

        }
        [HttpPut("update-account/{id}")]
        public async Task<IActionResult> UpdateAccount()
        {
            return Ok(Ok());
        }
    }
}
