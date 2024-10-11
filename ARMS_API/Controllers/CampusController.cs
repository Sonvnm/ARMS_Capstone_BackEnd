using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampusController : Controller
    {
        
        [HttpGet("count-campus")]
        public async Task<IActionResult> CountCampus()
        {
            return Ok();
        }
        [HttpGet("get-campuses")]
        public async Task<IActionResult> GetCampuses()
        {
            return Ok();
        }
        [HttpGet("get-campus")]
        public async Task<IActionResult> GetCampusess()
        {
            return Ok();
        }
        [HttpGet("get-sliders")]
        public async Task<IActionResult> GetSliders()
        {
            return Ok();
        }
        [HttpGet("get-history")]
        public async Task<IActionResult> GetHistory()
        {
            return Ok();
        }
        [HttpGet("get-achievements")]
        public async Task<IActionResult> GetAchievements()
        {
            return Ok();
        }
        [HttpGet("get-whychooseus")]
        public async Task<IActionResult> GetWhyChooseUs()
        {
            return Ok();
        }
        [HttpGet("get-trainingmotto")]
        public async Task<IActionResult> GetTrainingMotto()
        {
            return Ok();
        }
    }
}
