using Moveis.Data.Entity;
using Moveis.Data.Repositories.Interface;

namespace Moveis.Data.Repositories
{
    public class DirectorRepository:IDirectorRepository
    {
        private readonly MyFilmContext _filmContext;
        public DirectorRepository(MyFilmContext filmContext)
        {
            _filmContext = filmContext;
        }

        public void Add(Director director)
        {
            _filmContext.Add(director); 
            _filmContext.SaveChanges(); 

        }

        public void Delete(Director director)
        {
            _filmContext.Remove(director);
            _filmContext.SaveChanges();
        }

        public List<Director> GetAll()
        {
            return _filmContext.Directors.ToList();
        }

        public Director GetById(int id)
        {
            return _filmContext.Directors.Find(id);
        }

        public void SaveChanges()
        {
            _filmContext.SaveChanges();
        }
    }
}
