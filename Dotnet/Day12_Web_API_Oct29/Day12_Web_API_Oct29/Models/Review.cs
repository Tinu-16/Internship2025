namespace Day12_Web_API_Oct29.Models
{
    public class Review
    {
     public int Id {  get; set; }
     public int HotelId {  get; set; }
     public int CustomerId {  get; set; }
     public int Rating {  get; set; }
     public string Comment {  get; set; }
     public DateTime ReviewDate { get; set; } = DateTime.UtcNow;
     public Hotel Hotel {  get; set; }
     public Customer Customer {  get; set; }

    }
}
