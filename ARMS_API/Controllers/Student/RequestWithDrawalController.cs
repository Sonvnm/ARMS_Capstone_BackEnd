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
public class RequestWithDrawalController : BaseController
{
    private readonly IRequestService _requestService;

    public RequestWithDrawalController(
        IRequestService requestService,
        IMapper mapper,
        IAccountService accountService) : base(accountService, mapper)
    {
        _requestService = requestService;
    }

    [HttpGet("get-request-withdrawal")]
    public async Task<IActionResult> GetRequestWithdrawal()
    {
        try
        {
            var userId = GetUserId();
            var requests = await _requestService.GetRequestWithDrawalsByID(userId);
            var response = _mapper.Map<List<RequestWithDrawalDTO>>(requests);
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

    [HttpPost("add-request-withdrawal")]
    public async Task<IActionResult> AddRequestWithdrawal([FromBody] RequestWithDrawal_Student_DTO dto)
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
            request.CampusId = account.CampusId;
            request.isRequestChangeMajor = false;
            request.DateRequest = DateTime.UtcNow;

            await _requestService.AddNewRequest(request);

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
