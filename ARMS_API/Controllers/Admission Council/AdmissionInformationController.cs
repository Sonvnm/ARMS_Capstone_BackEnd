using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionInformationSer;
using Service.CampusSer;

namespace ARMS_API.Controllers.Admission_Council
{
    [Route("api/admission-council/[controller]")]
    [ApiController]
    public class AdmissionInformationController : ControllerBase
    {
        private IAdmissionInformationService _admissionInformationService;
        private ICampusService _campusService;
        private readonly IMapper _mapper;
        private ValidAdmissionInformation _validAdmissionInformation;
        public AdmissionInformationController(IAdmissionInformationService admissionInformationService, IMapper mapper, ICampusService campusService, ValidAdmissionInformation validAdmissionInformation)
        {
            _admissionInformationService = admissionInformationService;
            _mapper = mapper;
            _campusService = campusService;
            _validAdmissionInformation = validAdmissionInformation;
        }
        public async Task<IActionResult> GetAdmissionInformation(string CampusId)
        {
            try
            {
                List<AdmissionInformation> response = await _admissionInformationService.GetAdmissionInformation(CampusId);
                List<AdmissionInformation_AC_DTO> responeResult = _mapper.Map<List<AdmissionInformation_AC_DTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-admission-information-by-id")]
        public async Task<IActionResult> GetAdmissionInformationById(int AdmissionInformationID)
        {
            try
            {
                AdmissionInformation response = await _admissionInformationService.GetAdmissionInformationById(AdmissionInformationID);
                AdmissionInformation_AC_DTO responeResult = _mapper.Map<AdmissionInformation_AC_DTO>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("add-admission-information")]
        public async Task<IActionResult> AddAdmissionTime([FromBody] AdmissionInformation_Add_DTO AdmissionInformationDTO)
        {
            try
            {
                //check data
                await _validAdmissionInformation.ValidDataAdmissionInforAdd(AdmissionInformationDTO, AdmissionInformationDTO.CampusId);
                //mapper
                AdmissionInformation AdmissionInformation = _mapper.Map<AdmissionInformation>(AdmissionInformationDTO);
                //add new
                await _admissionInformationService.Add(AdmissionInformation);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Tạo mới thành công!"
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
        [HttpPut("update-admission-information")]
        public async Task<IActionResult> UpdateAdmissionInformation()
        {
            return Ok();
        }

    }
}
