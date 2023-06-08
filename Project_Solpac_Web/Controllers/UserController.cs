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
        [ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Lưu người dùng mới vào cơ sở dữ liệu
                _db.Users.Add(user);
                _db.SaveChanges();

                // Chuyển hướng đến trang thành công hoặc trang đăng nhập
                return RedirectToAction("Index", "Home");
            }

            // Trả về view đăng ký nếu dữ liệu không hợp lệ
            return View(user);
        }
    }
}
