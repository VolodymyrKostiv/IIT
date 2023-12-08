using IIT.BLL.DTOs.Bookings;
using IIT.Shared.ViewModels.Users;

namespace IIT.BLL.Services.Interfaces.Bookings
{
    public interface IBookingService
    {
        Task<IEnumerable<BookingDTO>> GetUserBookingsAsync(UserViewModel user);
    }
}
