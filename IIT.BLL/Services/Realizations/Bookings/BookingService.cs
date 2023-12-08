using AutoMapper;
using IIT.BLL.DTOs.Bookings;
using IIT.BLL.Services.Interfaces.Bookings;
using IIT.DAL.Repositories.Interfaces.Base;
using IIT.Shared.ViewModels.Users;

namespace IIT.BLL.Services.Realizations.Bookings
{
    public class BookingService : IBookingService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public async Task<IEnumerable<BookingDTO>> GetUserBookingsAsync(UserViewModel user)
        {
            var bookings = await _repoWrapper.BookingRepository.GetAllAsync(
                predicate: p => p.User.UserId == user.UserId);

            var mappedBookings = _mapper.Map<IEnumerable<BookingDTO>>(bookings);

            return mappedBookings;
        }
    }
}
