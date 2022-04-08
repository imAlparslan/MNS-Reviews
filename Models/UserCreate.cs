namespace MNS_Reviews.Models
{
    public class UserCreate
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IFormFile imgUrl { get; set; }
    }
}
