using Moveis.Service.Interface;
using Moveis.Data.Repositories.Interface;
using Moveis.Data.Entity;
using Moveis.ViewModel.Country;

namespace Moveis.Service
{
    public class CountryService:ICountryService
    {
        private readonly ICountryRepository _countryRepository ;
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository ;
        }

        public void Add(CountryAddEdit model)
        {
            var entityCountry = _countryRepository.GetById(model.Id);
            entityCountry.Id = model.Id;
            entityCountry.Name = model.Name;
            _countryRepository.Add(entityCountry);
            _countryRepository.SaveChanges();
        }

        public CountryAddEdit GetById(int id)
        {
            var entityCountry = _countryRepository.GetById(id);
            return new CountryAddEdit
            {
                Id = entityCountry.Id,
                Name = entityCountry.Name
            };
            
        }

        public void Update(CountryAddEdit model)
        {
            var entityCountry = _countryRepository.GetById(model.Id);
            entityCountry.Id = model.Id;
            entityCountry.Name = model.Name;
            _countryRepository.SaveChanges();

        }
    }
}
