using Microsoft.AspNetCore.Http;

namespace MNS_Reviews.Models
{
    public class MovieCreate
    {
        public string director { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string scenarist { get; set; }
        public string actors { get; set; }
        public string duration { get; set; }
        public string releaseDate { get; set; }
        public IFormFile imgUrl { get; set; }
    }
}
