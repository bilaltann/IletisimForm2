using IletisimForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;

namespace IletisimForm.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetUsers() 
        {
            return View();
        }
        public IActionResult CreateUser() 
        {

            return View();
        }

        public IActionResult VeriAl(User user)
        {
            if (ModelState.IsValid)
            {
                
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
      
            return View(user);
         
        }
    }
}
