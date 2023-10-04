using Microsoft.AspNetCore.Mvc;
using Moveis.Data.Repositories.Interface;
using Moveis.Models;
using Moveis.Service.Interface;
using Moveis.ViewModel.Film;
using System.Diagnostics;

namespace Moveis.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFilmService _filmService;
        public HomeController(IFilmService filmService)
        {
            _filmService = filmService;
        }
    
        public IActionResult Index(FilmAddEdit model)
        {
            
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
    }
}