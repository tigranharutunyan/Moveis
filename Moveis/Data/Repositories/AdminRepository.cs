using Moveis.Data.Entity;
using Moveis.Data.Repositories.Interface;

namespace Moveis.Data.Repositories
{
    public class AdminRepository:IAdminRepository
    {
        private readonly MyFilmContext _filmContext;
        public AdminRepository(MyFilmContext filmContext)
        {
            _filmContext = filmContext;
        }

        public void Add(Admin admin)
        {
            _filmContext.Add(admin);
            _filmContext.SaveChanges();
        }

        public void Delete(Admin admin)
        {
            _filmContext.Remove(admin);
            _filmContext.SaveChanges(); 

        }

        public List<Admin> GetAll()
        {
           return  _filmContext.Admins.ToList();
        }

        public Admin GetById(int id)
        {
            return  _filmContext.Admins.Find(id);
        }

        public void SaveChanges()
        {
            _filmContext.SaveChanges();
        }
    }
}
