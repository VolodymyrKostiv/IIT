using IIT.DAL.Entities.Users;
using IIT.DAL.Entities.Warehouses;
using System.ComponentModel.DataAnnotations;

namespace IIT.DAL.Entities.Bookings
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User User { get; set; }
        public Warehouse Warehouse { get; set; }
        public BookingStatus BookingStatus { get; set; }
    }
}
