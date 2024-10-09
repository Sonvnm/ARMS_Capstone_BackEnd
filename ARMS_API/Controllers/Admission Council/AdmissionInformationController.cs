using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers.Admission_Council
{
    public class AdmissionInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
