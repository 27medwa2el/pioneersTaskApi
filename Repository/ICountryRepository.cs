using PioneersApi.Models;
using PioneersApi.DTO;
namespace PioneersApi.Repository
{
    public interface ICountryRepository
    {
        public List<Country> GetAll();
        public void AddCountry(CountryDTO country);
        

    }
}
