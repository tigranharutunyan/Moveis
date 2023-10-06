using Moveis.ViewModel.Film;

namespace Moveis.Service.Interface
{
    public interface IFilmService
    {
        void Add(FilmAddEdit model);
        void Update(FilmAddEdit model);
        List<FilmAddEdit> GetDropDownList();
        //List<FilmAddEdit> Filter(FilmAddEditDropDown model);
        FilmAddEdit GetById(int id);
        void Delete(int id);
    }
}
