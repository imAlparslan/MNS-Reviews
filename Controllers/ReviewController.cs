using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;
namespace MNS_Reviews.Controllers
{
    public class ReviewController : Controller
    {
        private DataContext context;
        public ReviewController(DataContext _context)
        {
            this.context = _context;
        }


        public IActionResult Detail(int Id) 
        {
            Review review = context.reviews.First(i => i.PostId == Id);
            return View("ReviewDetail", review);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Review review)
        {
            context.reviews.Add(review);
            context.SaveChanges();
            return View();
        }



    }
}
