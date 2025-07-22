using ECommence.Api.Abstract;
using ECommence.Api.Models;
using System.Collections.Generic;

namespace ECommence.Api.Abstract
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public void UpdateCustomer(Customer customer)
        { 
            _customerRepository.UpdateCustomer(customer);
        }
    }
}
