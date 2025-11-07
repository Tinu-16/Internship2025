namespace Day12_Web_API_Oct29.DTO
{
    public class HotelResponse
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public RoomResponse room { get; set; }
    }
}
