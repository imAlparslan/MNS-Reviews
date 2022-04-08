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
            List<Comment> comments = context.comments.Where(x => x.Post.PostId == Id).ToList();
            ViewBag.Comments = comments;
            return View("ReviewDetail", review);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ReviewCreate p)
        {
            Review review = new Review();

            var extension = Path.GetExtension(p.imgUrl.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            p.imgUrl.CopyTo(stream);
            review.imgUrl = "~/images/" + newImageName;
            review.CreatedTimestamp = DateTime.Now;
            review.text = p.text;
            review.title = p.title;





            context.reviews.Add(review);
            context.SaveChanges();
            return View();
        }



    }
}
