using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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

                var claims = new List<Claim>
                {
                    new Claim("UserType", info.UserType),
                    new Claim(ClaimTypes.Name, info.Name),
                    new Claim("userId", info.Id.ToString()),
                };
                var userIdentity = new ClaimsIdentity(claims, info.UserType);
                
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            }



            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

    }

}
