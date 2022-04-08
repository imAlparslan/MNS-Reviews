using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Hosting.Server;

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
        public IActionResult Create(MovieCreate p)
        {
            Movie movie = new Movie();

            var extension = Path.GetExtension(p.imgUrl.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/",newImageName);
            var stream = new FileStream(location, FileMode.Create);
            p.imgUrl.CopyTo(stream);
            movie.imgUrl = "~/images/" + newImageName;
            movie.actors = p.actors;
            movie.releaseDate = p.releaseDate;
            movie.CreatedTimestamp = DateTime.Now;
            movie.scenarist = p.scenarist;
            movie.text = p.text;
            movie.title = p.title;
            movie.director = p.director;
            movie.duration = p.duration;




            context.movies.Add(movie);
            context.SaveChanges();
            return RedirectToAction("Movies", "Home");
        }

        private IActionResult UploadedFile(Movie model)
        {
          


            return Ok();
        }


        public IActionResult Detail(int Id)
        {
            Movie movie = context.movies.First(i => i.PostId == Id);
            List<Comment> comments = context.comments.Where(x => x.Post.PostId == Id).ToList();
            ViewBag.Comments = comments;
            return View("MovieDetail", movie);
        }
        
    }
}
