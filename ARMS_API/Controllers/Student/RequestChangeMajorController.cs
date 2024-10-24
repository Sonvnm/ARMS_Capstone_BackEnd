using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
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
        private IRequestService _requestChangeMajorService;
        private IAccountService _accountService;
        private readonly IMapper _mapper;
        public RequestChangeMajorController(IRequestService requestChangeMajorService, IMapper mapper, IAccountService accountService)
        {
            _requestChangeMajorService = requestChangeMajorService;
            _mapper = mapper;
            _accountService = accountService;
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
                List<Request> request = await _requestChangeMajorService.GetRequestChangeMajorsByID(Guid.Parse(userId));
                List<RequestChangeMajorDTO> responeResult = _mapper.Map<List<RequestChangeMajorDTO>>(request);
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
        [HttpGet("get-major")]
        public async Task<IActionResult> GetMajor()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized("Không tìm thấy ID người dùng!");
                }
                Account major = await _accountService.GetAccountByUserId(Guid.Parse(userId));
                Account_Major_DTO responeResult = _mapper.Map<Account_Major_DTO>(major);
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
        public async Task<IActionResult> AddRegisterAdmission([FromBody] RequestChangeMajor_Student_DTO requestChangeMajor_Student_DTO)
        {
            try
            {
                if (requestChangeMajor_Student_DTO == null)
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
                Request RequestChangeMajor = _mapper.Map<Request>(requestChangeMajor_Student_DTO);
                RequestChangeMajor.Status = TypeofRequestChangeMajor.Inprocess;
                RequestChangeMajor.AccountId = Guid.Parse(userId);
                RequestChangeMajor.MajorOld = account.MajorId;
                RequestChangeMajor.CampusId = account.CampusId;
                RequestChangeMajor.isRequestChangeMajor = true;
                RequestChangeMajor.DateRequest = DateTime.UtcNow;

                //add new
                await _requestChangeMajorService.AddNewRequest(RequestChangeMajor);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Gửi yêu cầu thành công!"
                });
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
