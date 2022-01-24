using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MNS_Reviews.Models
{ 

    [Table("Deneme")]
    public class Deneme
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name ="Name Area")]
        public string name { get; set; }
        public int age { get; set; }

        public DateTime CreatedTimestamp { get; set; }

                  


    }
}
