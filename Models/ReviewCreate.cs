namespace MNS_Reviews.Models
{
    public class ReviewCreate
    {
        public string title { get; set; }
        public string text { get; set; }
        public IFormFile imgUrl { get; set; }

    }
}
