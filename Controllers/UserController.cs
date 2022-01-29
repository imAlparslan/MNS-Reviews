using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MNS_Reviews.Models;

namespace MNS_Reviews.Controllers
{
    public class UserController : Controller
    {

        DataContext context;

        public UserController(DataContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            user.UserType = "User";
            context.users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Policy = "AdminPolicy")]
      
        public IActionResult UserList()
        {
            List<User> users = context.users.ToList();
            return View("Index", users);
        }


        [Authorize(Policy = "AdminPolicy")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = context.users.FirstOrDefault(x => x.Id == id);
            return View(user);

        }

        [Authorize(Policy = "AdminPolicy")]
        [HttpPost]
        public IActionResult Edit(User user)
        {
            User update = context.users.FirstOrDefault(x => x.Id == user.Id);
            update.UserType = user.UserType;
            user = update;
            
            context.users.Attach(user).Property(x => x.UserType).IsModified = true;
            context.Update(user);  
            context.SaveChanges();
            return RedirectToAction("UserList");

        }
        [Authorize(Policy ="AdminPolicy")]
       
        public IActionResult Delete(int id)
        {
            
            var user = context.users.FirstOrDefault(x => x.Id == id);
            context.users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("UserList");
        }


        /*
        public async Task<IActionResult> UpdateUser(User request)
        {
            User user = context.users.FirstOrDefault(x => x.Id == request.Id);
            user.CreatedDate = request.CreatedDate;
            user.Password = request.Password;
            user.Email = request.Email;
            user.UserType = "Editor";

            return Ok();
        }
        */

    }
}
