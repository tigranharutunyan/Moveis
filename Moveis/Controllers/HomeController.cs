using Microsoft.AspNetCore.Mvc;
using Moveis.Models;
using System.Diagnostics;

namespace Moveis.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult UserList()
        {

            return View();
        }
    }
}