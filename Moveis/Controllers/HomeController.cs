using Microsoft.AspNetCore.Mvc;
using Moveis.Models;
using System.Diagnostics;
using Moveis.Service.Interface;

namespace Moveis.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDirectorService _directorService;
        private readonly IFilmService _filmService;

        public HomeController(IDirectorService directorService, IFilmService filmService) { 
             _directorService = directorService;
            _filmService = filmService;

          }
        [HttpGet]
        public IActionResult Index()
        {
            var director = _directorService.GetListForDropDown();
            ViewBag.
            return View();
        }

        public IActionResult UserList()
        {

            return View();
        }
    }
}