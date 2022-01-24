using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;

namespace MNS_Reviews.Controllers
{
    public class UserController : Controller
    {

        DataContext context;
        
        public UserController(DataContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(User user)
        {
            context.users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Home", "Index");
        }



    }
}
