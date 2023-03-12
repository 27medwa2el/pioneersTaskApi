using PioneersApi.Models;

namespace PioneersApi.Repository
{
    public class CityRepository:ICityRepository
    {
        private ApplicationDbContext db;

        public CityRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public List<City> GetCityByCountry(int countryID)
        {
            var response = db.Cities.Where(a => a.CountryId == countryID).ToList();
            return response;
        }
        public List<City> GetAll()
        {
            return db.Cities.ToList();
        }
    }
}
