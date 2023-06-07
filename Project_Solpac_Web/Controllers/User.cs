using Microsoft.AspNetCore.Mvc;

namespace Project_Solpac_Web.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
