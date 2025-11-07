using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Request;
using Microsoft.AspNetCore.Mvc;

namespace Day12_Web_API_Oct29.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service) 
        {
            _service = service;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllEmployees()
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
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> Add(AddEmployee employee)
        {
            var result = await _service.Add(employee);
            return Ok(result);
        }
        [HttpPut("UpdateEmployeeById")]
        public async Task<IActionResult> Update(int id, UpdateEmployee employee)
        {
            var result = await _service.Update(id, employee);
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
