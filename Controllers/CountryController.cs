using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PioneersApi.DTO;
using PioneersApi.Repository;

namespace PioneersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data = countryRepository.GetAll();
            List<DropDownViewDTO>response= new List<DropDownViewDTO>();
            foreach (var item in data)
            {
                var country = new DropDownViewDTO { Id = item.CountryId, Name = item.CountryName };
                response.Add(country);
            }
            return Ok(response);
        }
        [HttpPost]
        public IActionResult AddCountry(CountryDTO country)
        {
            countryRepository.AddCountry(country);
            return Ok();
        }
    }
}
