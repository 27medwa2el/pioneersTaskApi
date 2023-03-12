using PioneersApi.Models;

namespace PioneersApi.Repository
{
    public interface ICityRepository
    {
        public List<City> GetCityByCountry(int countryID);
        public List<City> GetAll();
    }
}
