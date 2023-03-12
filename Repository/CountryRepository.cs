using PioneersApi.DTO;
using PioneersApi.Models;

namespace PioneersApi.Repository
{
    public class CountryRepository:ICountryRepository
    {
        private ApplicationDbContext db;

        public CountryRepository(ApplicationDbContext db) 
        {
          this.db = db;
        }
        public List<Country> GetAll()
        {
            return db.Countries.ToList();
        }
        public void AddCountry(CountryDTO country)
        {     
            Country country1 = new Country();
            country1.CountryName=country.Name;
            db.Countries.Add(country1);
        }
    }
}
