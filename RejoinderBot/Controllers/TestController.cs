using Microsoft.AspNetCore.Mvc;

namespace RejoinderBot.Controllers
{
    [Route("test")]
    public class TestController : Controller
    {
        [HttpGet]
        [Route("health")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
