using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;
using System.Linq;
namespace MNS_Reviews.Controllers


{

    public class DenemeController : Controller
    {
        private DataContext context;
        public DenemeController(DataContext _context) 
        { 
            context = _context; 
        }


        [Authorize]
        public IActionResult Index()
        {
            var claims = HttpContext.User.Claims;
            return View();
        }

     
        [Authorize(Policy = "AdminPolicy")]
        [HttpGet]
        public IActionResult AddDeneme()
        {
           

            return View();
        }

        [Authorize(Policy = "AdminPolicy")]
        [HttpPost]
        public IActionResult AddDeneme(Deneme deneme)
        {
            
            if (!ModelState.IsValid)
            {
                return View("AddDeneme");
            }
            
            context.denemes.Add(deneme);
            context.SaveChanges();
            
            return View("Thx",deneme);
        }
    }
}
