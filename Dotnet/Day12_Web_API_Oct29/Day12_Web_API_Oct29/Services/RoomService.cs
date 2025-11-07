using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;
using Microsoft.EntityFrameworkCore;

namespace Day12_Web_API_Oct29.Services
{
    public class RoomService : IRoomService
    {
        private readonly HotelDbContext _dbContext;

        public RoomService(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _dbContext.Rooms
                .Include(h => h.RoomType)
                .Include(h => h.Bookings)
                .ToListAsync();
        }
        public async Task<Room> GetById(int id)
        {
            return await _dbContext.Rooms
                .Include(h => h.Bookings)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
        public async Task<string> Add(AddRoomsDto room)
        {
            try
            {
                var addRoom = new Room
                {
                    RoomNumber = room.RoomNumber,
                    HotelId = room.HotelId,
                    RoomTypeId = room.RoomTypeId,
                    Status = room.Status,
                    PricePerNight = room.PricePerNight,
                };
                _dbContext.Rooms.Add(addRoom);
                int result = await _dbContext.SaveChangesAsync();
                return "Success";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
        public async Task<string> Update(int id, UpdateRoomsDto room)
        {
            try
            {
                var rooms = await _dbContext.Rooms.FindAsync(id);

                if (rooms == null)
                    return $"No Room with the id : {id} exists";
                else
                {
                    if (room.RoomTypeId.HasValue)
                        rooms.RoomTypeId = room.RoomTypeId.Value;

                    if (room.Status.HasValue)
                        rooms.Status = room.Status.Value;

                    if (room.PricePerNight != null)
                        rooms.PricePerNight = room.PricePerNight.Value;

                }

                int result = await _dbContext.SaveChangesAsync();
                if (result > 0)
                    return $"Room updated successfully";
                else
                    return $"Error occurred while updating the room";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
        public async Task<string> Delete(int id)
        {
            try
            {
                var room = await _dbContext.Hotels.FindAsync(id);

                if (room == null)
                    return $"No Room with the id : {id} exists";

                _dbContext.Hotels.Remove(room);
                int result = await _dbContext.SaveChangesAsync();

                if (result > 0)
                    return "Room deleted successfully";
                else
                    return "Error occurred while deleting room";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
    }
}
