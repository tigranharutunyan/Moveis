using Microsoft.AspNetCore.Mvc;

namespace Moveis.Controllers
{
    public class RegistrationController : Controller
    { }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrationForm()
        {
            return View();
          }
        public IActionResult RegFilm()
        {
            ViewBag.Diectors = _directorService
            ViewBag.Country = _countryService.GetDropDownList();
            return View();
        }
    }
}
