using Microsoft.AspNetCore.Mvc;

namespace MNS_Reviews.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

    }

}
