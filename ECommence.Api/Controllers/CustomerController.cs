using Microsoft.AspNetCore.Mvc;
using ECommence.Api.Abstract;
using ECommence.Api.Models;

namespace ECommence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }

        [HttpPost]
        public IActionResult CreateCustomer([FromBody] Customer newCustomer)
        {
            if (newCustomer == null)
                return BadRequest("Customer data is null.");

            _customerService.AddCustomer(newCustomer);
            return CreatedAtAction(nameof(GetAll), null, newCustomer);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(string id, [FromBody] Customer updatedCustomer)
        {
            if (updatedCustomer == null || id != updatedCustomer.CustomerID)
                return BadRequest("Customer ID mismatch.");

            _customerService.UpdateCustomer(updatedCustomer);
            return NoContent();  
        }


    }
}
