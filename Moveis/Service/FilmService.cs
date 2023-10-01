using Moveis.Data.Entity;
using Moveis.Data.Repositories.Interface;
using Moveis.Service.Interface;
using Moveis.ViewModel.Film;

namespace Moveis.Service
{
    public class FilmService:IFilmService
    {
        private readonly IFilmRepostory _filmRepostory;
        public FilmService(IFilmRepostory filmRepostory)
        {
            _filmRepostory = filmRepostory;
        }

        public void Add(FilmAddEdit model)
        {
            var entityFilm = new Film()
            {
                Id = model.Id,
                Name = model.Name,
                AllowAge = model.AllowAge,
                DOC = model.DOC,
                Lenguage = model.Lenguage,
                Genre = model.Genre,
                Quality = model.Quality,
                DirectorId = model.DirectorsId,
                CountryId = model.CountryId,
                Duration = model.Duration,
            };
            _filmRepostory.Add(entityFilm);
            _filmRepostory.SaveChanges();
        }

        public void Delete(int id)
        {
            var entityFilm =  _filmRepostory.GetById(id);
            _filmRepostory.Delete(entityFilm);
        }

        //public List<FilmAddEdit> Filter(FilmAddEditDropDown model)
        //{
        //    var entityFilm = _filmRepostory.GetAll().Any(e => (e.Name.ToLower() == model.Name.ToLower() || (e.Genre == model.Genre))
        //    && (e.Lenguage == model.Lenguage) || (e.CountryId == model.CountryId) || (e.AllowAge == model.AllowAge));
        //    return 
        //}

        public FilmAddEdit GetById(int id)
        {
            var entityFilm = _filmRepostory.GetById(id);
            return new FilmAddEdit()
            {
                Id=entityFilm.Id,
                Name=entityFilm.Name,
                DOC = entityFilm.DOC,
                AllowAge = entityFilm.AllowAge,
                Duration = entityFilm.Duration,
                Lenguage = entityFilm.Lenguage,
                Genre = entityFilm.Genre,
                Quality = entityFilm.Quality,
                CountryId  = entityFilm.CountryId,
                DirectorsId = entityFilm.DirectorId,
            };
        }

        public List<FilmAddEdit> GetDropDownList()
        {
            var entityFilm = _filmRepostory.GetAll();
            return entityFilm.Select(e => new FilmAddEdit
            {
                Id = e.Id,
                Name = e.Name,  
            }).ToList();
        }

        public void Update(FilmAddEdit model)
        {
            var entityFilm = _filmRepostory.GetById(model.Id);
            entityFilm.Id = model.Id;   
            entityFilm.Name = model.Name;
            entityFilm.AllowAge = model.AllowAge;
            entityFilm.DOC = model.DOC;
            entityFilm.Quality = model.Quality;
            entityFilm.Lenguage = model.Lenguage;
            entityFilm.Genre = model.Genre;
            entityFilm.Duration = model.Duration;
            entityFilm.DirectorId = model.DirectorsId;
            entityFilm.CountryId =model.CountryId;
            _filmRepostory.SaveChanges();
        }
    }
}
