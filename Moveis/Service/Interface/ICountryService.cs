using Moveis.ViewModel.Country;

namespace Moveis.Service.Interface
{
    public interface ICountryService
    {
        void Add(CountryAddEdit model);
        void Update(CountryAddEdit model);
        CountryAddEdit GetById(int id);
        List<CountryDropDown> GetDropDownList();
    }
}
