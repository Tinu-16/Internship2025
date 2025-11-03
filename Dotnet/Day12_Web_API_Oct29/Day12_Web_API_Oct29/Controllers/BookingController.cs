using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Request;
using Microsoft.AspNetCore.Mvc;

namespace Day12_Web_API_Oct29.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController:ControllerBase
    {
        public readonly IBookingService _service;
        public BookingController(IBookingService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllBookings()
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
        [HttpPost("AddBooking")]
        public async Task<IActionResult> Add(AddBooking booking)
        {
            var result = await _service.Add(booking);
            return Ok(result);
        }
        [HttpPut("UpdateBookingById")]
        public async Task<IActionResult> Update(int id, UpdateBooking booking)
        {
            var result = await _service.Update(id, booking);
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
