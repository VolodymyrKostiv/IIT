using System.ComponentModel.DataAnnotations;

namespace IIT.DAL.Entities.Bookings
{
    public class BookingStatus
    {
        [Key]
        public int BookingStatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
