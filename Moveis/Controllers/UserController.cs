using Microsoft.AspNetCore.Mvc;
using Moveis.Service.Interface;
using Moveis.ViewModel.User;

namespace Moveis.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
           
           

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

        [HttpPost]
        public IActionResult Login(UserLoginViewModel model)
        {
            if (_userService.Login(model))
            {

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Something is wrong ";
             }
          
            return View();

        }
        public IActionResult RegUser()
        {
            ViewBag.Country = _countryService.GetDropDownList();
            return View();
        }
    }
}
