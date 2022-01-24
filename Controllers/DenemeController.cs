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


        
        public IActionResult Index()
        {
            return View();
        }


        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult AddDeneme()
        {
            
            return View();
        }

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
