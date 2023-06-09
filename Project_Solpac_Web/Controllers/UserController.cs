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
        public IActionResult Index()
        {
            IEnumerable<User> objUserList = _db.Users;
            return View(objUserList);
        }

        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
