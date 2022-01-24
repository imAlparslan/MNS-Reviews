using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MNS_Reviews.Models
{

    [Table("Review")]
    public class Review : Post
    {
        public string imgUrl { get; set; }

    }
}
