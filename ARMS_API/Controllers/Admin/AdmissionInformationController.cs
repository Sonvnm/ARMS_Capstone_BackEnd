using ARMS_API.ValidData;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionInformationSer;
using Service.CampusSer;

namespace ARMS_API.Controllers.Admin
{
    public class AdmissionInformationController : Controller
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
        [HttpPut("update-admission-information")]
        public async Task<IActionResult> UpdateAdmissionInformation()
        {
           return Ok();
        }
    }
}
