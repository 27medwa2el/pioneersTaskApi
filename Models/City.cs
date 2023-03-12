using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PioneersApi.Models
{
    public class City
    {
        public int CityId { get; set; }
        [Required]
        public string CityName { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country country { get; set; }
        public virtual List<Customer> Customers { get; set;} = new List<Customer>();
       

    }
}
