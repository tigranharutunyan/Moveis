using Microsoft.AspNetCore.Mvc;
using Moveis.Service.Interface;
using Moveis.ViewModel.Film;
namespace Moveis.Controllers
{
    public class FilmController : Controller
    {
        private readonly IFilmService _filmService;
        private readonly IDirectorService _directorService; 
        public FilmController(IFilmService filmService, IDirectorService directorService) { 
            _filmService = filmService; 
            _directorService = directorService; 
         } 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SearchFilm() {
            FilmFilterViewModel model = new FilmFilterViewModel();
            ViewBag.FilmFilter = _filmService.Filter(model);
            return View();
         }

        //[HttpPost]
        //public IActionResult SearchFilm(FilmAddEdit model)
        //{
        //    FilmFilterViewModel model = new FilmFilterViewModel();
        //    ViewBag.FilmFilter = _filmService.Filter(model);
        //    return View();
        //}

    }
}
