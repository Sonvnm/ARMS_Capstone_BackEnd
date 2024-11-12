using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionInformationSer;
using Service.AdmissionTimeSer;
using Service.CampusSer;

namespace ARMS_API.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
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
        
        //[HttpPut("update-admission-information")]
        //public async Task<IActionResult> UpdateAdmissionInformation(AdmissionInformation_Update_DTO AdmissionInformationDTO)
        //{
        //    try
        //    {
        //        var checkdata = await _campusService.GetCampus(AdmissionInformationDTO.CampusId);
        //        if (checkdata == null) return NotFound();
        //        //check data
        //        _validAdmissionInformation.ValidDataAdmissionInfor(AdmissionInformationDTO);
        //        //mapper
        //        AdmissionInformation admissionInformation = _mapper.Map<AdmissionInformation>(AdmissionInformationDTO);
        //        await _admissionInformationService.UpdateAdmissionInformation(admissionInformation);
        //        return Ok(new ResponseViewModel()
        //        {
        //            Status = true,
        //            Message = "Cập nhật thành công!"
        //        });

        //    }
        //    catch (Exception)
        //    {

        //        return BadRequest();
        //    }
        //}
    }
}
