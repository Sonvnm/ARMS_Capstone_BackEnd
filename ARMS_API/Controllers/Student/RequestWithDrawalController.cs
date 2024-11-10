using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.RequestChangeMajorSer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        // GET: api/RequestWithDrawal/get-request-withdrawal
        [HttpGet("get-request-withdrawal")]
        public async Task<IActionResult> GetRequestWithdrawal()
        {
            try
            {
                var userId = GetUserId(); // Retrieve user ID
                var requests = await _requestService.GetRequestWithDrawalsByID(userId);

                if (requests == null || requests.Count == 0)
                {
                    return Ok(new { Status = true, Message = "No withdrawal requests found." });
                }

                var response = _mapper.Map<List<RequestWithDrawalDTO>>(requests);
                return Ok(response);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new ResponseViewModel
                {
                    Status = false,
                    Message = ex.Message
                });
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                // Example: _logger.LogError(ex, "Error occurred while fetching withdrawal requests.");

                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }

        // POST: api/RequestWithDrawal/add-request-withdrawal
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
                request.isRequestChangeMajor = false; // No major change for withdrawal
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
                return Unauthorized(new ResponseViewModel
                {
                    Status = false,
                    Message = ex.Message
                });
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                // Example: _logger.LogError(ex, "Error occurred while adding a withdrawal request.");

                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }
    }
}
