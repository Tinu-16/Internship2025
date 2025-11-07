using Day12_Web_API_Oct29.Request;
using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;
using Microsoft.EntityFrameworkCore;

namespace Day12_Web_API_Oct29.Services
{
    public class HotelService :IHotelService
    {
        private readonly HotelDbContext _dbContext;

        public HotelService(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Hotel>> GetAll()
        {
            return await _dbContext.Hotels
                .Include(h => h.Rooms)
                .Include(h => h.Employees)
                .ToListAsync();
        }
        public async Task<Hotel> GetById(int id)
        {
            return await _dbContext.Hotels
                .Include(h => h.Rooms)
                .Include(h => h.Employees)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
        public async Task<int> Add(AddHotelDto hotel)
        {
            var addHotel = new Hotel
            {
                Name = hotel.Name,
                Address = hotel.Address,
                City = hotel.City,
                Country = hotel.Country,
                PhoneNumber = hotel.PhoneNumber,
            };
            _dbContext.Hotels.Add(addHotel);
            int result = await _dbContext.SaveChangesAsync();
            return result;
        }
        public async Task<string> Update(int id, UpdateHotelDto hotel)
        {
            try
            {
                var hotels = await _dbContext.Hotels.FindAsync(id);

                if (hotels == null)
                    return $"No Hotel with the id : {id} exists";
                else
                {
                    if (!string.IsNullOrWhiteSpace(hotel.Name))
                        hotels.Name = hotel.Name;

                    if (!string.IsNullOrWhiteSpace(hotel.Address))
                        hotels.Address = hotel.Address;

                    if (!string.IsNullOrWhiteSpace(hotel.City))
                        hotels.City = hotel.City;

                    if (!string.IsNullOrWhiteSpace(hotel.Country))
                        hotels.Country = hotel.Country;

                    if (!string.IsNullOrWhiteSpace(hotel.PhoneNumber))
                        hotels.PhoneNumber = hotel.PhoneNumber;
                }

                int result = await _dbContext.SaveChangesAsync();
                if (result > 0)
                    return $"Hotel updated successfully";
                else
                    return $"Error occurred while updating the hotel";
            }
            catch(Exception ex) 
            {
                return $"An error occurred while updating the hotel: {ex.Message}";
            }
        }
        public async Task<string> Delete(int id)
        {
            try
            {
                var hotel = await _dbContext.Hotels.FindAsync(id);

                if (hotel == null)
                    return $"No Hotel with the id : {id} exists";

                _dbContext.Hotels.Remove(hotel);
                int result = await _dbContext.SaveChangesAsync();

                if (result > 0)
                    return "Hotel deleted successfully";
                else
                    return "Error occurred while deleting hotel";
            }
            catch (Exception ex)
            {
                return $"An error occurred while deleting hotel: {ex.Message}";
            }
        }
    }
}
