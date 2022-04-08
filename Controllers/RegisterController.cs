using Microsoft.AspNetCore.Mvc;

namespace MNS_Reviews.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ValidRegister()
        {
            return View();
        }
    }
}
