using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionInformationSer;
using Service.AdmissionTimeSer;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmissionInformationController : ControllerBase
    {
        private IAdmissionInformationService _admissionInformationService;
        private readonly IMapper _mapper;
        public AdmissionInformationController(IAdmissionInformationService admissionInformationService, IMapper mapper)
        {
            _admissionInformationService = admissionInformationService;
            _mapper = mapper;
        }
        [HttpGet("get-admission-information")]
        public async Task<IActionResult> GetAdmissionInformation(string CampusId)
        {
            try
            {
                // lấy ra đợt đang tuyển sinh
                AdmissionInformation response = await _admissionInformationService.GetAdmissionInformationProcess(CampusId);
                if (response == null)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Đã hết đợt tuyển sinh!"
                    });
                }
                AdmissionInformationDTO responeResult = _mapper.Map<AdmissionInformationDTO>(response);
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
