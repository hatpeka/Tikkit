using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Project_Solpac_Web.Data;
using Project_Solpac_Web.Models;
using System;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Project_Solpac_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SolpacClientDbContext _db;

        public HomeController(SolpacClientDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var User = _db.Users.FirstOrDefault(u=> u.Name == username);
            if (User != null && User.Name == username && User.Password == password)
            {
                return View();
            }
            return RedirectToAction("Index");  
        }

        //Register
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            var User = _db.Users.FirstOrDefault(u => u.Name == username);
            if (User != null && User.Name == username && User.Password == password)
            {
                return View();
            }
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}