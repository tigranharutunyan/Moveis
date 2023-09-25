using Moveis.ViewModel.Film;

namespace Moveis.Service.Interface
{
    public interface IFilmService
    {
        void Add(FilmAddEdit model);
        void Update(FilmAddEdit model);
        FilmAddEdit GetById(int id);
    }
}
