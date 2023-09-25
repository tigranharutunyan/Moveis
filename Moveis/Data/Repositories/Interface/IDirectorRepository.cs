using Moveis.Data.Entity;

namespace Moveis.Data.Repositories.Interface
{
    public interface IDirectorRepository
    {
        void Add(Director director);
        Director GetById(int id);
        List<Director> GetAll();
        void Delete(Director director);
        void SaveChanges();
    }
}
