using Moveis.Data.Entity;

namespace Moveis.Data.Repositories.Interface
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetById(int id);
        List<User> GetAll();
        void Delete(User user);
        void SaveChanges();
    }
}
