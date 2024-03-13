using Microsoft.AspNetCore.Mvc;
using mission10_walker_backend.Data;

namespace mission10_walker_backend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BowlerData()
        {
            return View();
        }
    }
}
