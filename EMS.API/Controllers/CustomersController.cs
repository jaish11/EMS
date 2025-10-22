using EMS.Application.Services;
using EMS.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _service;
        public CustomersController(CustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAllCustomers());

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_service.GetCustomerById(id));

        [HttpPost]
        public IActionResult Create([FromBody] CustomerDTO dto)
        {
            _service.AddCustomer(dto);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] CustomerDTO dto)
        {
            _service.UpdateCustomer(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteCustomer(id);
            return Ok();
        }
    }
}
