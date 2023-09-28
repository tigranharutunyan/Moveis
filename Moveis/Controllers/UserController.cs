using Microsoft.AspNetCore.Mvc;
using Moveis.Service.Interface;
using Moveis.ViewModel.User;

namespace Moveis.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()
        {
            
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
        public IActionResult Login(UserLogViewModel model)
        {
            if (_userService.Login(model))
            {

                return RedirectToAction("UserList", "Home");
            }
            else
            {
                ViewBag.Error = "Something is vrong ";
            }
          
            return View();

        }
    }
}
