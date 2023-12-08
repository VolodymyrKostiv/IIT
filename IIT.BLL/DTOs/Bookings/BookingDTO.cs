using IIT.BLL.DTOs.Users;
using IIT.BLL.DTOs.Warehouses;

namespace IIT.BLL.DTOs.Bookings
{
    public class BookingDTO
    {
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public UserDTO User { get; set; }
        public WarehouseDTO Warehouse { get; set; }
        public BookingStatusDTO BookingStatus { get; set; }
    }
}
