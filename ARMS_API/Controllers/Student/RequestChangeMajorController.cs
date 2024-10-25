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
public class RequestChangeMajorController : BaseController
{
    private readonly IRequestService _requestChangeMajorService;

    public RequestChangeMajorController(
        IRequestService requestChangeMajorService,
        IMapper mapper,
        IAccountService accountService) : base(accountService, mapper)
    {
        _requestChangeMajorService = requestChangeMajorService;
    }

    [HttpGet("get-request-change-major")]
    public async Task<IActionResult> GetRequestChangeMajor()
    {
        try
        {
            var userId = GetUserId();
            var requests = await _requestChangeMajorService.GetRequestChangeMajorsByID(userId);
            var response = _mapper.Map<List<RequestChangeMajorDTO>>(requests);
            return Ok(response);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(ex.Message);
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
    public async Task<IActionResult> AddRequestChangeMajor([FromBody] RequestChangeMajor_Student_DTO dto)
    {
        try
        {
            if (dto == null)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Không nhận được dữ liệu yêu cầu!"
                });
            }

            var userId = GetUserId();
            var account = await _accountService.GetAccountByUserId(userId);
            if (account == null)
            {
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Không tìm thấy tài khoản người dùng!"
                });
            }

            var request = _mapper.Map<Request>(dto);
            request.Status = TypeofRequestChangeMajor.Inprocess;
            request.AccountId = userId;
            request.MajorOld = account.MajorId;
            request.CampusId = account.CampusId;
            request.isRequestChangeMajor = true;
            request.DateRequest = DateTime.UtcNow;

            await _requestChangeMajorService.AddNewRequest(request);

            return Ok(new ResponseViewModel
            {
                Status = true,
                Message = "Gửi yêu cầu thành công!"
            });
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(ex.Message);
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
