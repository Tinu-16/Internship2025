using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;
using Microsoft.AspNetCore.Mvc;

namespace Day12_Web_API_Oct29.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController: ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var result = await _service.GetAll();
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetById(id);
            return Ok(result);
        }
        [HttpPost("AddCustomer")]
        public async Task<IActionResult> Add(AddCustomer customer)
        {
            var result = await _service.Add(customer);
            return Ok(result);
        }
        [HttpPut("UpdateCustomerById")]
        public async Task<IActionResult> Update(int id, UpdateCustomer customer)
        {
            var result = await _service.Update(id, customer);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.Delete(id);
            return Ok(result);
        }
    }
}
