using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Request;
using Microsoft.AspNetCore.Mvc;

namespace Day12_Web_API_Oct29.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomTypeController:ControllerBase
    {
        private readonly IRoomType _service;

        public RoomTypeController(IRoomType service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllRoomTypes()
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
        [HttpPost("AddRoomTypes")]
        public async Task<IActionResult> Add(RoomTypeDto roomType)
        {
            var result = await _service.Add(roomType);
            return Ok(result);
        }
        [HttpPut("UpdateRoomTypeById")]
        public async Task<IActionResult> Update(int id, RoomTypeDto roomType)
        {
            var result = await _service.Update(id, roomType);
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
