using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Request;
using Microsoft.AspNetCore.Mvc;

namespace Day12_Web_API_Oct29.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _service;

        public RoomController(IRoomService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllRooms()
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
        [HttpPost("AddRoom")]
        public async Task<IActionResult> Add(AddRoomsDto room)
        {
            var result = await _service.Add(room);
            return Ok(result);
        }
        [HttpPut("UpdateRoomById")]
        public async Task<IActionResult> Update(int id, UpdateRoomsDto room)
        {
            var result = await _service.Update(id, room);
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
