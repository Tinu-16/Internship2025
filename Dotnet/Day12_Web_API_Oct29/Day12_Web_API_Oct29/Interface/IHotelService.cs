using Day12_Web_API_Oct29.Request;
using Day12_Web_API_Oct29.Models;

namespace Day12_Web_API_Oct29.Interface
{
    public interface IHotelService
    {
        Task<IEnumerable<Hotel>> GetAll();
        Task<Hotel> GetById(int id);
        Task<int> Add(AddHotelDto hotel);
        Task<string> Update(int id, UpdateHotelDto hotel);
        Task<string> Delete(int id);
    }
}
