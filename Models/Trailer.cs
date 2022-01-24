using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MNS_Reviews.Models
{

    [Table("Trailer")]
    public class Trailer:Post
    {

        public string link { get; set; }
 
        /*
        public Trailer(string title, string text) : base(title, text)
        {
            
        }
        */
    }
}
