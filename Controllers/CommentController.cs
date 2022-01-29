using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;
using System.Linq;

namespace MNS_Reviews.Controllers
{
    public class CommentController : Controller
    {
        private DataContext context;

        public CommentController(DataContext _context)
        {
            this.context = _context;
        }

        
        public List<Comment> FindComments(Post post)
        {
           List<Comment> comments = context.comments.Where(x => x.Post.PostId == post.PostId).ToList();


            return comments; 


        } 



        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            context.comments.Add(comment);
            context.SaveChanges();

            return Ok();
        }

     }
}
