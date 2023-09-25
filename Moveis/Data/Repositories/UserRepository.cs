using Moveis.Data.Entity;
using Moveis.Data.Repositories.Interface;

namespace Moveis.Data.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly MyFilmContext _filmContext;    
        public UserRepository(MyFilmContext filmContext)
        {
            _filmContext = filmContext; 
        }

        public void Add(User user)
        {
            _filmContext.Add(user);
            _filmContext.SaveChanges();
        }

        public void Delete(User user)
        {
            _filmContext.Remove(user);
            _filmContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _filmContext.Users.ToList();
        }

        public User GetById(int id)
        {
            return _filmContext.Users.Find(id);
        }

        public void SaveChanges()
        {
            _filmContext.SaveChanges();
        }
    }
}
