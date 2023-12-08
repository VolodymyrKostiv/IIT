using IIT.BLL.DTOs.Bookings;

namespace IIT.BLL.DTOs.Users
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserTypeDTO UserType { get; set; }
        public UserDetailsDTO UserDetails { get; set; }
        public ICollection<BookingDTO> Bookings { get; set; }
    }
}
