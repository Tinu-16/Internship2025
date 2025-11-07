using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;

namespace Day12_Web_API_Oct29.Interface
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room> GetById(int id);
        Task<string> Add(AddRoomsDto room);
        Task<string> Update(int id, UpdateRoomsDto room);
        Task<string> Delete(int id);
    }
}
