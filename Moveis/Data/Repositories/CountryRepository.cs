using Moveis.Data.Entity;
using Moveis.Data.Repositories.Interface;

namespace Moveis.Data.Repositories
{
    public class CountryRepository:ICountryRepository
    {
        private readonly MyFilmContext _filmContext;
        public CountryRepository(MyFilmContext myFilmContext)
        {
            _filmContext = myFilmContext;
        }

        public void Add(Country country)
        {
            _filmContext.Add(country);
            _filmContext.SaveChanges();

        }

        public void Delete(Country country)
        {
            _filmContext.Remove(country);
            _filmContext.SaveChanges();

        }

        public List<Country> GetAll()
        {
            return _filmContext.Countries.ToList();
        }

        public Country GetById(int id)
        {
            return _filmContext.Countries.Find(id);
        }

        public void SaveChanges()
        {
            _filmContext.SaveChanges();
        }
    }
}
