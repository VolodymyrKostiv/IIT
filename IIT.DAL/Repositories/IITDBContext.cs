using IIT.DAL.Entities.Bookings;
using IIT.DAL.Entities.Users;
using IIT.DAL.Entities.Warehouses;
using Microsoft.EntityFrameworkCore;

namespace IIT.DAL.Repositories
{
    public class IITDBContext : DbContext
    {
        public IITDBContext()
        {
            
        }

        public IITDBContext(DbContextOptions<IITDBContext> opt) : base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingStatus> BookingsStatus { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseDetails> WarehouseDetails { get; set; }
        public DbSet<WarehouseType> WarehouseTypes { get; set; }
    }
}
