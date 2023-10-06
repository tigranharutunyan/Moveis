using Microsoft.AspNetCore.Mvc;
using Moveis.Data.Repositories.Interface;
using Moveis.Models;
using Moveis.Service.Interface;
using Moveis.ViewModel.Film;
using System.Diagnostics;
using Moveis.Service.Interface;
using Moveis.ViewModel.Film;

namespace Moveis.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDirectorService _directorService;
        private readonly IFilmService _filmService;

        public HomeController(IDirectorService directorService, IFilmService filmService)
        {
            _directorService = directorService;
            _filmService = filmService;

        }
        [HttpGet]
        public IActionResult Index()
        {
            FilmAddEditDropDown model = new FilmAddEditDropDown();
            ViewBag.Filter = _filmService.GetByFilter(model);
            return View();
        }

        [HttpPost]
        public IActionResult Index(FilmAddEditDropDown model)
        {
            ViewBag.Filter = _filmService.GetByFilter(model);
            return View();

        }
        public IActionResult UserList()
        {

            return View();
        }

        public IActionResult FilmFilter(FilmAddEditDropDown model)
        {
            ViewBag.film = _filmService.GetByFilter(model);
            return View();
        }
        public IActionResult FilmFilter(FilmAddEditDropDown model)
        {
             ViewBag.film = _filmService.GetByFilter(model);
            return View();
        }
    }
}