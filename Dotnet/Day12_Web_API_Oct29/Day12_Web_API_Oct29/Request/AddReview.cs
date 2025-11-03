namespace Day12_Web_API_Oct29.Request
{
    public class AddReview
    {
        public int HotelId { get; set; }
        public int CustomerId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
