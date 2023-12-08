using IIT.DAL.Entities.Bookings;
using IIT.DAL.Repositories.Interfaces.Bookings;
using IIT.DAL.Repositories.Realizations.Base;

namespace IIT.DAL.Repositories.Realizations.Bookings
{
    public class BookingStatusRepository : RepositoryBase<BookingStatus>, IBookingStatusRepository
    {
        public BookingStatusRepository(IITDBContext dbcontext) : base(dbcontext)
        {
            
        }
    }
}
