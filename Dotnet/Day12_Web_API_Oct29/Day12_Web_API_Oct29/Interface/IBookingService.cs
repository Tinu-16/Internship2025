using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;

namespace Day12_Web_API_Oct29.Interface
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetAll();
        Task<Booking?> GetById(int id);
        Task<Booking> Add(AddBooking booking);
        Task<Booking?> Update(int id, UpdateBooking booking);
        Task<bool> Delete(int id);
    }
}
