using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PioneersApi.DTO;
using PioneersApi.Models;

namespace PioneersApi.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public void AddCustomer(CustomerDTO customer)
        {
            Customer customerObg = new Customer { Name = customer.Name, Address = customer.Address, CityId = customer.CityID, CountryId = customer.CountryID, PhoneNumber = customer.PhoneNumber };
            _context.Customers.Add(customerObg);
            _context.SaveChanges();
        }
        public List<Customer> GetAll()
        {
            var response = _context.Customers.ToList();
            return response;
        }
    }
}
