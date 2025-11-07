using Day12_Web_API_Oct29.Models;

namespace Day12_Web_API_Oct29.Request
{
    public class UpdateBooking
    {
        public int? RoomId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public BookingStatus? Status { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
