using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.RequestChangeMajorSer;

namespace ARMS_API.Controllers.Student
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Student")]
    public class RequestWithDrawalController : ControllerBase
    {
        private IRequestService _request;
        private IAccountService _accountService;
        private readonly IMapper _mapper;
        public RequestWithDrawalController(IRequestService requestChangeMajorService, IMapper mapper, IAccountService accountService)
        {
            _request = requestChangeMajorService;
            _mapper = mapper;
            _accountService = accountService;
        }
        [HttpGet("get-request-with-drawal")]
        public async Task<IActionResult> GetRequestWithDrawal()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Vui lòng đăng nhập lại để tiếp tục sử dụng!"
                    });
                }
                List<Request> request = await _request.GetRequestWithDrawalsByID(Guid.Parse(userId));
                List<RequestWithDrawalDTO> responeResult = _mapper.Map<List<RequestWithDrawalDTO>>(request);
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
        [HttpPost("add-request-change-major")]
        public async Task<IActionResult> AddRegisterAdmission([FromBody] RequestWithDrawal_Student_DTO RequestWithDrawal_Student_DTO)
        {
            try
            {

                if (RequestWithDrawal_Student_DTO == null)
                {
                    return BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Không nhận được dữ liệu yêu cầu!"
                    });
                }
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Vui lòng đăng nhập lại để tiếp tục sử dụng!"
                    });
                }
                //get acccount by userId
                var account = await _accountService.GetAccountByUserId(Guid.Parse(userId));
                if (account == null)
                {
                    return BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Không tìm thấy tài khoản người dùng!"
                    });
                }
                //mapper
                Request Request = _mapper.Map<Request>(RequestWithDrawal_Student_DTO);
                Request.Status = TypeofRequestChangeMajor.Inprocess;
                Request.AccountId = Guid.Parse(userId);
                Request.CampusId = account.CampusId;
                Request.isRequestChangeMajor = false;
                Request.DateRequest = DateTime.UtcNow;

                //add new
                await _request.AddNewRequest(Request);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Gửi yêu cầu thành công!"
                });
            }
            catch (Exception ex)
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
