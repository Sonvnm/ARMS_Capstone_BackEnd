using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.RequestChangeMajorSer;
using System;

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

        // GET: api/Student/RequestChangeMajor/get-request-change-major
        [HttpGet("get-request-change-major")]
        public async Task<IActionResult> GetRequestChangeMajor()
        {
            try
            {
                var userId = GetUserId(); // Get logged-in user ID
                var requests = await _requestChangeMajorService.GetRequestChangeMajorsByID(userId);
                if (requests == null || requests.Count == 0)
                {
                    return Ok(new { Status = false, Message = "Không có yêu cầu nào." });
                }

                var response = _mapper.Map<List<RequestChangeMajorDTO>>(requests);
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
                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
        }

        // POST: api/Student/RequestChangeMajor/add-request-change-major
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
                return Unauthorized(new ResponseViewModel
                {
                    Status = false,
                    Message = ex.Message
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
