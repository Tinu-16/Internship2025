namespace Day12_Web_API_Oct29.Models
{
    public class Room
    {
      public int Id {  get; set; }
      public string RoomNumber {  get; set; }
      public int HotelId {  get; set; }
      public int RoomTypeId {  get; set; }
      public RoomStatus Status {  get; set; }
      public decimal PricePerNight {  get; set; }
      public Hotel Hotel{ get; set; }
      public RoomType RoomType {  get; set; }
      public List<Booking> Bookings { get; set; } = new List<Booking>();

    }

}
