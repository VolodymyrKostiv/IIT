using IIT.DAL.Entities.Bookings;
using System.ComponentModel.DataAnnotations;

namespace IIT.DAL.Entities.Users
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public UserDetails UserDetails { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
