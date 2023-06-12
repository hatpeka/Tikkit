using Microsoft.AspNetCore.Mvc;
using Project_Solpac_Web.Data;
using Project_Solpac_Web.Models;

namespace Project_Solpac_Web.Controllers
{
    public class RequestController : Controller
    {
        private readonly SolpacClientDbContext _db;

        public RequestController(SolpacClientDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Request> objRequestList = _db.Requests;
            return View(objRequestList);
        }

        //Get
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Request obj)
        {
            _db.Requests.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
