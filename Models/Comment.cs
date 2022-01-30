using System.ComponentModel.DataAnnotations.Schema;

namespace MNS_Reviews.Models
{

    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public User CommentOwner { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }

        public String OwnerName { get; set; }
        public string CommentText { get; set; }




    }
}
