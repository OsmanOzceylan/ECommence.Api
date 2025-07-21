using ECommence.Api;
using ECommence.Api.Data;
using Microsoft.AspNetCore.Mvc;
namespace ECommence.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository;


            public CustomersController()
        {

        }
         
        [HttpGet]
        public IActionResult GetAll()
        {
            var cr = new CustomerRepository();
         
            var customers = cr.GetCustomers();
            return Ok(customers);
        }
    }
}
