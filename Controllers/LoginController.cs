using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;

using System.Security.Claims;

namespace MNS_Reviews.Controllers
{
    public class LoginController : Controller
    {
        private DataContext context;

        public LoginController(DataContext _context)
        {
            context = _context;
        }


        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            List<User> users = context.users.ToList();
            
            var info = users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            if(info != null)
            {
                FormsAuthentication
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, user.Email),
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("AddDeneme", "Deneme");
            }



            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

    }

}
