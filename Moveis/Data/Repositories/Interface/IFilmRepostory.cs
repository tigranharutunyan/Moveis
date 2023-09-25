using Moveis.Data.Entity;

namespace Moveis.Data.Repositories.Interface
{
    public interface IFilmRepostory
    {
        void Add(Film film);
        Film GetById(int id);
        List<Film> GetAll();
        void Delete(Film film);
        void SaveChanges();

    }
}
