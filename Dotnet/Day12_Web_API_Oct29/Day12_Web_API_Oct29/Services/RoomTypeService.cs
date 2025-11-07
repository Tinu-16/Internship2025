using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Day12_Web_API_Oct29.Services
{
    public class RoomTypeService: IRoomType
    {
        private readonly HotelDbContext _dbContext;

        public RoomTypeService(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<RoomType>> GetAll()
        {
            try
            {
                return await _dbContext.RoomTypes
                    .Include(h => h.Rooms)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching RoomTypes: {ex.Message}");
                throw;
            }
        }
        public async Task<RoomType> GetById(int id)
        {
            try
            {
                return await _dbContext.RoomTypes
                .Include(h => h.Rooms)
                .FirstOrDefaultAsync(a => a.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching RoomTypes: {ex.Message}");
                throw;
            }
        }
        public async Task<string> Add(RoomTypeDto roomType)
        {
            try
            {
                var addRoomType = new RoomType
                {
                   TypeName= roomType.TypeName,
                   Description= roomType.Description,
                   Capacity = roomType.Capacity.Value
                };
                _dbContext.RoomTypes.Add(addRoomType);
                int result = await _dbContext.SaveChangesAsync();
                return "Success";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
        public async Task<string> Update(int id, RoomTypeDto roomType)
        {
            try
            {
                var roomTyp = await _dbContext.RoomTypes.FindAsync(id);

                if (roomTyp == null)
                    return $"No Room with the id : {id} exists";
                else
                {
                    if (!string.IsNullOrWhiteSpace(roomType.TypeName))
                        roomTyp.TypeName = roomType.TypeName;

                    if (!string.IsNullOrWhiteSpace(roomType.Description))
                        roomTyp.Description = roomType.Description;

                    if (roomType.Capacity != null)
                        roomTyp.Capacity = roomType.Capacity.Value;
                }

                int result = await _dbContext.SaveChangesAsync();
                if (result > 0)
                    return $"Room Type updated successfully";
                else
                    return $"Error occurred while updating the room type";
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
                var roomTyp = await _dbContext.RoomTypes.FindAsync(id);

                if (roomTyp == null)
                    return $"No Room with the id : {id} exists";

                _dbContext.RoomTypes.Remove(roomTyp);
                int result = await _dbContext.SaveChangesAsync();

                if (result > 0)
                    return "Room type deleted successfully";
                else
                    return "Error occurred while deleting room type";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
    }
}
