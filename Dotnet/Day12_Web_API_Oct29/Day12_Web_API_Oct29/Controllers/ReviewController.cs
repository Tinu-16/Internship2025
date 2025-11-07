using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Request;
using Microsoft.AspNetCore.Mvc;

namespace Day12_Web_API_Oct29.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _service;

        public ReviewController(IReviewService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllReviews()
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
        [HttpPost("AddReview")]
        public async Task<IActionResult> Add(AddReview review)
        {
            var result = await _service.Add(review);
            return Ok(result);
        }
        [HttpPut("UpdateReviewById")]
        public async Task<IActionResult> Update(int id, UpdateReview review)
        {
            var result = await _service.Update(id, review);
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
