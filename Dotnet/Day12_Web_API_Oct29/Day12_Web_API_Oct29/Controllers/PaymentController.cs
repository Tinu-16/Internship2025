using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Request;
using Microsoft.AspNetCore.Mvc;

namespace Day12_Web_API_Oct29.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController:ControllerBase
    {
        private readonly IPaymentService _service;

        public PaymentController(IPaymentService service)
        {
            _service = service; 
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllPayments()
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
        [HttpPost("AddPayment")]
        public async Task<IActionResult> Add(AddPayment payment)
        {
            var result = await _service.Add(payment);
            return Ok(result);
        }
        [HttpPut("UpdatePaymentById")]
        public async Task<IActionResult> Update(int id, UpdatePayment payment)
        {
            var result = await _service.Update(id, payment);
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
