using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Service.BlogSer;
using Service.RequestChangeMajorSer;
using static Google.Apis.Requests.BatchRequest;

namespace ARMS_API.Controllers.SchoolService
{
    [Route("api/SchoolService/[controller]")]
    [ApiController]
    //[Authorize(Roles = "SchoolService")]
    public class RequestChangeMajorController : ControllerBase
    {
        private IRequestService _requestChangeMajorService;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public RequestChangeMajorController(IRequestService requestChangeMajorService, IMapper mapper, UserInput userInput)
        {
            _requestChangeMajorService = requestChangeMajorService;
            _mapper = mapper;
            _userInput = userInput;
        }
        [HttpGet("get-request-change-major")]
        public async Task<IActionResult> GetRequestChangeMajor(string CampusId, string? Search, int CurrentPage, TypeofRequestChangeMajor? Status)
        {
            try
            {
                ResponeModel<RequestChangeMajor_SS_DTO> result = new ResponeModel<RequestChangeMajor_SS_DTO>
                {
                    CurrentPage = CurrentPage,
                    CampusId = CampusId,
                    Search = Search
                };

                List<Request> response = await _requestChangeMajorService.GetRequestChangeMajors(CampusId);

                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(request =>
                                {
                                    string description = _userInput.NormalizeText(request?.Description ?? "");
                                    string majorNew = _userInput.NormalizeText(request?.MajorNew ?? "");
                                    string fullname = _userInput.NormalizeText(request?.Account?.Fullname ?? "");
                                    string studentCode = _userInput.NormalizeText(request?.Account?.StudentCode ?? "");
                                    string majorNameOld = _userInput.NormalizeText(request?.MajorO?.MajorName ?? "");
                                    string majorNameNew = _userInput.NormalizeText(request?.MajorN?.MajorName ?? "");
                                    return description.Contains(searchTerm) ||
                                           majorNew.Contains(searchTerm) ||
                                           fullname.Contains(searchTerm) ||
                                           studentCode.Contains(searchTerm) ||
                                           majorNameOld.Contains(searchTerm) ||
                                           majorNameNew.Contains(searchTerm);
                                })
                                .ToList();
                }


                // Apply Status filter
                if (Status.HasValue)
                {
                    response = response
                                .Where(request => request != null && request.Status == Status)
                                .ToList();
                }

                // Pagination
                result.PageCount = (int)Math.Ceiling(response.Count / (double)result.PageSize);
                var majors = response
                    .Skip((CurrentPage - 1) * result.PageSize)
                    .Take(result.PageSize)
                    .ToList();

                // Map results to DTOs
                result.Item = _mapper.Map<List<RequestChangeMajor_SS_DTO>>(majors);
                result.TotalItems = response.Count;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPut("accept-request-change-major")]
        public async Task<IActionResult> AddRequest(int RequestID, [FromBody] Reply_Request_DTO Reply_Request_DTO)
        {
            try
            {

                Request request =await _requestChangeMajorService.GetRequestByID(RequestID);
                request.Status = Reply_Request_DTO.Status;
                request.Reply = Reply_Request_DTO.Reply;
                //add new
                await _requestChangeMajorService.UpdateRequest(request);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Chỉnh sửa thành công!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
    }
}
