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
        public IActionResult Create(SerieCreate p)
        {
            Serie serie = new Serie();

            var extension = Path.GetExtension(p.imgUrl.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            p.imgUrl.CopyTo(stream);
            serie.imgUrl = "~/images/" + newImageName;
            serie.actors = p.actors;
            serie.relaseDate = p.relaseDate;
            serie.CreatedTimestamp = DateTime.Now;
            serie.scenarist = p.scenarist;
            serie.text = p.text;
            serie.title = p.title;
            serie.director = p.director;
            serie.season = p.season;




            context.series.Add(serie);
            context.SaveChanges();

            return Redirect("/home");
            
        }


        public IActionResult Detail(int Id)
        {
            Serie serie = context.series.First(i => i.PostId == Id);
            List<Comment> comments = context.comments.Where(x => x.Post.PostId == Id).ToList();
            ViewBag.Comments = comments;
            return View("SerieDetail", serie);
        }
        
    }
}
