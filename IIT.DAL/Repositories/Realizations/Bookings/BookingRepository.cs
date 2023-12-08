using IIT.DAL.Entities.Bookings;
using IIT.DAL.Repositories.Interfaces.Bookings;
using IIT.DAL.Repositories.Realizations.Base;

namespace IIT.DAL.Repositories.Realizations.Bookings
{
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(IITDBContext dbcontext) : base(dbcontext)
        {
            
        }
    }
}
