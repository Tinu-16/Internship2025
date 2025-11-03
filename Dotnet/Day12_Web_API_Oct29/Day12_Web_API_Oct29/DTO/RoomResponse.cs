using Day12_Web_API_Oct29.Models;

namespace Day12_Web_API_Oct29.DTO
{
    public class RoomResponse
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public RoomStatus Status { get; set; }
        public decimal PricePerNight { get; set; }
        public List<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
