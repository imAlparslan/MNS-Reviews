using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MNS_Reviews.Models
{
    [Table("Movie")]
    public class Movie : Post
    {

        public string director { get; set; }
        public string scenarist { get; set; }
        public string actors { get; set; }
        public string duration { get; set; }
        public string releaseDate { get; set; }


    }
 }