using Common.Dtos;
using Common.Services;
using CustomersApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CustomersApi.Controllers
{
    public class CustomerController : ControllerBase
    {
        private readonly ILogger _logger;

        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Registers a customer
        /// </summary>
        [HttpPost("customers/register")]
        public IActionResult RegisterAsync([FromBody] CustomerDto customer)
        {
            _logger.LogInformation("Customer with email: " + customer.Email + " registered");

            return Ok(new SuccessMessage());
        }
    }
}
