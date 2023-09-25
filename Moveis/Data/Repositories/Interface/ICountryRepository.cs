using Moveis.Data.Entity;

namespace Moveis.Data.Repositories.Interface
{
    public interface ICountryRepository
    {
        void Add(Country country);
        Country GetById(int id);
        List<Country> GetAll();
        void Delete(Country country);
        void SaveChanges();
    }
}
