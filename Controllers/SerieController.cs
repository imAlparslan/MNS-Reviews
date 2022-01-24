using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;
namespace MNS_Reviews.Controllers
{
    public class SerieController : Controller
    {
        private DataContext context;
        public SerieController(DataContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Create(Serie serie)
        {
            context.series.Add(serie);
            context.SaveChanges();

            return Redirect("/home");
            
        }


        public IActionResult Detail(int Id)
        {
            Serie serie = context.series.First(i => i.PostId == Id);
            return View("SerieDetail", serie);
        }
        
    }
}
