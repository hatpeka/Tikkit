using Microsoft.AspNetCore.Mvc;
using Project_Solpac_Web.Data;
using Project_Solpac_Web.Models;

namespace Project_Test.Controllers
{
    public class UserController : Controller
    {
        private readonly SolpacClientDbContext _db;

        public UserController(SolpacClientDbContext db)
        {
            _db = db;
        }

        // GET: /User/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /User/Register
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }
    }
}
