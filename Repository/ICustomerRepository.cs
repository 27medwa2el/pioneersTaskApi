using Microsoft.AspNetCore.Mvc;
using PioneersApi.DTO;
using PioneersApi.Models;

namespace PioneersApi.Repository
{
    public interface ICustomerRepository
    {
        public void AddCustomer(CustomerDTO customer);
        public List<Customer> GetAll();

    }
}
