namespace Day12_Web_API_Oct29.Request
{
    public class UpdateEmployee
    {
        public int? HotelId { get; set; }
        public string? FullName { get; set; }
        public string? Role { get; set; }
        public string? Email { get; set; }
    }
}
