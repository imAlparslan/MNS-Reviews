using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;
namespace MNS_Reviews.Controllers
{
    public class TrailerController : Controller
    {
        private DataContext context;
        public TrailerController(DataContext _context)
        {
            this.context = _context;
        }
        
        public IActionResult Detail(int Id)
        {

            Trailer trailer = context.trailers.First(i => i.PostId == Id);
            return View("TrailerDetail", trailer);
        }
        

        [HttpGet]
        public IActionResult Create() { return View(); }


        [HttpPost]
        public IActionResult Create(Trailer trailer)
        {   
            context.trailers.Add(trailer);
            context.SaveChanges();
            return View();
        }
    
    }


   
}
