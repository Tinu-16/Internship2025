using Microsoft.EntityFrameworkCore;

namespace Day12_Web_API_Oct29.Models
{
    public class HotelDbContext : DbContext
    {

        public HotelDbContext(DbContextOptions<HotelDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Enum conversions
            modelBuilder.Entity<Room>()
                .Property(r => r.Status)
                .HasConversion<int>();

            modelBuilder.Entity<Booking>()
                .Property(b => b.Status)
                .HasConversion<int>();

            modelBuilder.Entity<Payment>()
                .Property(p => p.Status)
                .HasConversion<int>();

            modelBuilder.Entity<Payment>()
                .Property(p => p.Method)
                .HasConversion<int>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
