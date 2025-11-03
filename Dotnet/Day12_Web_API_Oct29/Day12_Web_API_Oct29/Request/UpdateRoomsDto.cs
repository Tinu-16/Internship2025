using Day12_Web_API_Oct29.Models;

namespace Day12_Web_API_Oct29.Request
{
    public class UpdateRoomsDto
    {
        public int? RoomTypeId { get; set; }
        public RoomStatus? Status { get; set; }
        public decimal? PricePerNight { get; set; }
    }
}
