using Microsoft.AspNetCore.Mvc;

namespace Moveis.Controllers
{
    public class DisplayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayIndex()
        {
            return View();
        }
    }
}
