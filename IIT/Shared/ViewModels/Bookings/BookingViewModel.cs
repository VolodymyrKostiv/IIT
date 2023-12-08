using IIT.Shared.ViewModels.Users;
using IIT.Shared.ViewModels.Warehouses;

namespace IIT.Shared.ViewModels.Bookings
{
    public class BookingViewModel
    {
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public UserViewModel User { get; set; }
        public WarehouseViewModel Warehouse { get; set; }
        public BookingStatusViewModel BookingStatus { get; set; }
    }
}
