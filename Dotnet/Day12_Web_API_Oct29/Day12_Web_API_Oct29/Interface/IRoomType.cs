using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;

namespace Day12_Web_API_Oct29.Interface
{
    public interface IRoomType
    {
        Task<IEnumerable<RoomType>> GetAll();
        Task<RoomType> GetById(int id);
        Task<string> Add(RoomTypeDto roomType);
        Task<string> Update(int id, RoomTypeDto roomType);
        Task<string> Delete(int id);
    }
}
