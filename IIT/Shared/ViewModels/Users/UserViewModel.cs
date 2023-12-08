using IIT.Shared.ViewModels.Bookings;

namespace IIT.Shared.ViewModels.Users
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserTypeViewModel UserType { get; set; }
        public UserDetailsViewModel UserDetails { get; set; }
        public ICollection<BookingViewModel> Bookings { get; set; }
    }
}
