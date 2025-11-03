namespace Day12_Web_API_Oct29.Models
{
    public class Customer
    {
        public int Id {  get; set; }
        public string FullName {  get; set; }
        public string Email {  get; set; }
        public string PhoneNumber {  get; set; }
        public string IdProofNumber {  get; set; }
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
