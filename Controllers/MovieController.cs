using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;
namespace MNS_Reviews.Controllers
{
    public class MovieController : Controller
    {
        private DataContext context;

        public MovieController(DataContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Create(Movie movie)
        {
            context.movies.Add(movie);
            context.SaveChanges();
            return Redirect("/home");

        }
        
        public IActionResult Detail(int Id)
        {
            Movie movie = context.movies.First(i => i.PostId == Id);
            return View("MovieDetail", movie);
        }
        
    }
}
