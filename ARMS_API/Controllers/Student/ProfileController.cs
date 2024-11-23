using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;

namespace ARMS_API.Controllers.Student
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Student")]
    public class ProfileController : ControllerBase
    {
        private IAccountService _accountService;
        private readonly IMapper _mapper;
        public ProfileController(IMapper mapper, IAccountService accountService)
        {
            _mapper = mapper;
            _accountService = accountService;
        }
        [HttpGet("get-profile")]
        public async Task<IActionResult> GetMajor()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId)) return Unauthorized("Không tìm thấy ID người dùng!");
                Account major = await _accountService.GetAccountByUserId(Guid.Parse(userId));
                Account_DTO responeResult = _mapper.Map<Account_DTO>(major);
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
