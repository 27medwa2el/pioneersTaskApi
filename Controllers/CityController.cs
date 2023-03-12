using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PioneersApi.DTO;
using PioneersApi.Models;
using PioneersApi.Repository;

namespace PioneersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository cityRepository;
        public CityController(ICityRepository cityRepository) { 
            
            this.cityRepository=cityRepository;
   
        }
        [HttpGet]
        public IActionResult GetCitesByCountry(int id)
        {
            var data = cityRepository.GetCityByCountry(id);
            List<DropDownViewDTO> response = new List<DropDownViewDTO>();
            foreach (var item in data)
            {
                var city = new DropDownViewDTO { Id = item.CityId, Name = item.CityName };
                response.Add(city);
            }
            return Ok(response);
        }
    }
}
