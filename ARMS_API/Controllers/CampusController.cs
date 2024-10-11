using Microsoft.AspNetCore.Mvc;

namespace ARMS_API.Controllers
{
    public class CampusController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
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

    }
}
