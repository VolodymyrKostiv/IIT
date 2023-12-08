using AutoMapper;
using IIT.BLL.DTOs.Bookings;
using IIT.DAL.Entities.Bookings;

namespace IIT.BLL.Mapping.Bookings
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<Booking, BookingDTO>().ReverseMap();
            CreateMap<BookingStatus, BookingStatusDTO>().ReverseMap();
        }
    }
}
