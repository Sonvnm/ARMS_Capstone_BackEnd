//using AutoMapper;
//using Data.DTO;
//using Data.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Service.AdmissionGroupSer;

//namespace ARMS_API.Controllers.AdmissionCouncil
//{
//    [Route("api/admission-council/[controller]")]
//    [ApiController]
//    public class AdmissionGroupController : ControllerBase
//    {
//        private IAdmissionGroupService _admissionGroupService;
//        private readonly IMapper _mapper;
//        public AdmissionGroupController(IAdmissionGroupService admissionGroupService, IMapper mapper)
//        {
//            _admissionGroupService = admissionGroupService;
//            _mapper = mapper;
//        }
//        [HttpGet("get-admission-score")]
//        public async Task<IActionResult> GetAdmission(string CampusId, int year)
//        {
//            try
//            {
//                List<Data.Models.AdmissionGroup> response = await _admissionGroupService.GetAdmissionGroupAsync(CampusId, year);
//                List<AdmissionGroup_AC_DTO> responeResult = _mapper.Map<List<AdmissionGroup_AC_DTO>>(response);
//                return Ok(responeResult);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }
//    }
//}
