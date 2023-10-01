using Microsoft.AspNetCore.Mvc;
using Moveis.Service.Interface;
using Moveis.ViewModel.User;

namespace Moveis.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICountryService _countryService;
        private readonly IDirectorService _directorService;
        public UserController(ICountryService countryService,IUserService userService,IDirectorService directorService)
        {
            _userService = userService;
            _countryService = countryService;
            _directorService = directorService;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Login(UserViewModel model)
        //{
        //    if (_userService.Login(model))
        //    {

        //        return RedirectToAction("UserList", "Home");
        //    }
        //    else
        //    {
        //        ViewBag.Error = "Something is wrong ";
        //    }
          
        //    return View();

        //}
       public IActionResult RegFilm()
        {
            ViewBag.Diectors = _directorService
            ViewBag.Country = _countryService.GetDropDownList();
            return View();
        }
    }
}
