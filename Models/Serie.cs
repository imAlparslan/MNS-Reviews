using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MNS_Reviews.Models
{
    [Table("Serie")]
    public class Serie:Post
    {
        public string director { get; set; }
        public string scenarist { get; set; }
        public string actors { get; set; }
        public string season { get; set; }
        public string relaseDate { get; set; }

    }
}
