using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;
using System.Diagnostics;

namespace MNS_Reviews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataContext context;

        public HomeController(ILogger<HomeController> logger, DataContext _dataContext)
        {
            _logger = logger;
            context = _dataContext;
        }
        private List<Post> GetAllPost()
        {
            List<Post> posts = context.posts.ToList();
   

            return posts;
        }

        private List<Movie> GetAllMovie()
        {
            List<Movie> movies = context.movies.ToList();


            return movies;
        }

        private List<Serie> GetAllSeries()
        {
            List<Serie> series = context.series.ToList();


            return series;
        }
        private List<Trailer> GetAllTrailer()
        {
            List<Trailer> trailers = context.trailers.ToList();


            return trailers;
        }

        private List<Review> GetAllReview()
        {
            List<Review> reviews = context.reviews.ToList();
            
            return reviews;
        }

        public IActionResult Index()
        {
            List<Post> posts = GetAllPost();
            return View(posts);
        }

        public IActionResult Movies()
        {   
            List<Movie> movies = GetAllMovie();
            return View("MoviesList", movies);
        }
        public IActionResult Series()
        {
            List<Serie> series = GetAllSeries();
            return View("SeriesList", series);
        }

        public IActionResult Trailers()
        {
            List<Trailer> trailers = GetAllTrailer();
            return View("TrailersList", trailers);
        }

        public IActionResult Reviews()
        {
            List<Review> reviews = GetAllReview();
            return View("ReviewsList", reviews);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}