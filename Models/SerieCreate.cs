namespace MNS_Reviews.Models
{
    public class SerieCreate
    {
        public string director { get; set; }
        public string scenarist { get; set; }
        public string actors { get; set; }
        public string season { get; set; }
        public string relaseDate { get; set; }
        public IFormFile imgUrl { get; set; }
        public string title { get; set; }
        public string text { get; set; }


    }
}
