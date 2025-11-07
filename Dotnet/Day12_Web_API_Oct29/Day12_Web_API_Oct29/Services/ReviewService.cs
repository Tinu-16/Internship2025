using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;
using Microsoft.EntityFrameworkCore;

namespace Day12_Web_API_Oct29.Services
{
    public class ReviewService : IReviewService
    {
        private readonly HotelDbContext _dbContext;

        public ReviewService(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Review>> GetAll()
        {
            return await _dbContext.Reviews
             .Include(h => h.Hotel)
             .Include(h => h.Customer)
             .ToListAsync();
        }
        public async Task<Review?> GetById(int id)
        {
            return await _dbContext.Reviews
            .Include(h => h.Hotel)
            .Include(h => h.Customer)
            .FirstOrDefaultAsync(h => h.Id== id);
        }
        public async Task<Review> Add(AddReview review)
        {
            var addReview = new Review
            {
               HotelId= review.HotelId,
               CustomerId=review.CustomerId,
               Rating=review.Rating,
               Comment=review.Comment
            };
            _dbContext.Reviews.Add(addReview);
            int result = await _dbContext.SaveChangesAsync();
            return addReview;
        }
        public async Task<Review?> Update(int id, UpdateReview review)
        {
            var reviewUpdate = await _dbContext.Reviews.FindAsync(id);
            if (reviewUpdate == null)
                return null;
            else
            {
                if (review.Rating.HasValue)
                    reviewUpdate.Rating = review.Rating.Value;
                if (!string.IsNullOrWhiteSpace(review.Comment))
                    reviewUpdate.Comment = review.Comment;
            }
            await _dbContext.SaveChangesAsync();
            return reviewUpdate;
        }
        public async Task<bool> Delete(int id)
        {
            var review = await _dbContext.Reviews.FindAsync(id);
            if (review == null)
                return false;
            _dbContext.Reviews.Remove(review);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
