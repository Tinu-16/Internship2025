using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;
using Microsoft.EntityFrameworkCore;

namespace Day12_Web_API_Oct29.Services
{
    public class BookingService : IBookingService
    {
        public readonly HotelDbContext _dbContext;
        public BookingService(HotelDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Booking>> GetAll()
        {
            return await _dbContext.Bookings
               .Include(h => h.Customer)
               .Include(h => h.Room)
               .Include(h => h.Payment)
               .ToListAsync();
        }
        public async Task<Booking?> GetById(int id)
        {
            return await _dbContext.Bookings
              .Include(h => h.Customer)
              .Include(h => h.Room)
              .Include(h => h.Payment)
              .FirstOrDefaultAsync(h =>h.Id == id);
        }
        public async Task<Booking> Add(AddBooking booking)
        {
            var addBooking = new Booking
            {
                CustomerId = booking.CustomerId,
                RoomId = booking.RoomId,
                CheckInDate = booking.CheckInDate,
                CheckOutDate = booking.CheckOutDate,
                Status = booking.Status,
                TotalAmount = booking.TotalAmount,
            };
            _dbContext.Bookings.Add(addBooking);
            int result = await _dbContext.SaveChangesAsync();
            return addBooking;

        }
        public async Task<Booking?> Update(int id, UpdateBooking booking)
        {
            var bookings = await _dbContext.Bookings.FindAsync(id);
            if (bookings == null)
                return null;
            else
            {
                if (booking.RoomId.HasValue)
                    bookings.RoomId = booking.RoomId.Value;
                if (booking.CheckInDate != null)
                    bookings.CheckInDate = booking.CheckInDate.Value;
                if (booking.CheckOutDate != null)
                    bookings.CheckOutDate = booking.CheckOutDate.Value;
                if(booking.Status.HasValue)
                    bookings.Status= booking.Status.Value;
                if( booking.TotalAmount.HasValue)
                    bookings.TotalAmount = booking.TotalAmount.Value;
            }
            await _dbContext.SaveChangesAsync();
            return bookings;
        }
        public async Task<bool> Delete(int id)
        {
            var booking = await _dbContext.Bookings.FindAsync(id);
            if (booking == null)
                return false;
            _dbContext.Bookings.Remove(booking);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
