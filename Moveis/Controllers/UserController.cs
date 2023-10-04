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

      
    }
}
