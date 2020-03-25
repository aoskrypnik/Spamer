using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("/about")]
    public class AboutController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }
    }
}