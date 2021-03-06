using System.ComponentModel;

namespace MNS_Reviews.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public Boolean IsActive { get; set; }

        public string imgUrl { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


    }
}
