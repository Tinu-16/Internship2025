using Day12_Web_API_Oct29.Models;

namespace Day12_Web_API_Oct29.Request
{
    public class AddPayment
    {
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
