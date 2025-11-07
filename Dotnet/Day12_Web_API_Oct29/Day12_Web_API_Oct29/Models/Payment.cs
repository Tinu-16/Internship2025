namespace Day12_Web_API_Oct29.Models
{
    public class Payment
    {
        public int Id {  get; set; }
        public int BookingId {  get; set; }
        public DateTime PaymentDate {  get; set; } = DateTime.Now;
        public decimal Amount {  get; set; }
        public PaymentMethod Method {  get; set; }
        public PaymentStatus Status {  get; set; }
        public Booking Booking {  get; set; }

    }

}
