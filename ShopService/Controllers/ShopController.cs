using Microsoft.AspNetCore.Mvc;

namespace ShopService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("merge");
        }
    }
}
