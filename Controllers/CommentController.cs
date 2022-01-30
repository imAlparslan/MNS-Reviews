using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
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
        [Authorize(Policy ="EditorPolicy")]
        public IActionResult Delete(Comment comment)
        {
            
          //s  Comment del = context.comments.Where(x => x.Id == comment).FirstOrDefault();
            context.comments.Remove(comment);
            
            context.SaveChanges();

            return Ok();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            context.comments.Add(comment);
            
            context.SaveChanges();

            return RedirectToAction("index","home");
        }

        public User findUser(int id)
        {
           return context.users.FirstOrDefault(x => x.Id == id);
        }



     }
}
