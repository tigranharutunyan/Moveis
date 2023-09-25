using Moveis.Data.Entity;

namespace Moveis.Data.Repositories.Interface
{
    public interface IAdminRepository
    {
        void Add(Admin admin);
        Admin GetById(int id);
        List<Admin> GetAll();
        void Delete(Admin admin);
        void SaveChanges();
    }
}
