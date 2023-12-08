using AutoMapper;
using IIT.BLL.DTOs.Bookings;
using IIT.Shared.ViewModels.Bookings;

namespace IIT.Server.Mapping.Bookings
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<BookingDTO, BookingViewModel>().ReverseMap();
            CreateMap<BookingStatusDTO, BookingStatusViewModel>().ReverseMap();
        }
    }
}
