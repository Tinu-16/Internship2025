using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;

namespace Day12_Web_API_Oct29.Interface
{
    public interface IReviewService
    {
        Task<IEnumerable<Review>> GetAll();
        Task<Review?> GetById(int id);
        Task<Review> Add(AddReview payment);
        Task<Review?> Update(int id, UpdateReview payment);
        Task<bool> Delete(int id);
    }
}
