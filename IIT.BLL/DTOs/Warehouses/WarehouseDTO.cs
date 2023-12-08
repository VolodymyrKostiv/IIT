using IIT.BLL.DTOs.Bookings;

namespace IIT.BLL.DTOs.Warehouses
{
    public class WarehouseDTO
    {
        public int WarehouseId { get; set; }
        public WarehouseDetailsDTO WarehouseDetails { get; set; }
        public ICollection<BookingDTO> Bookings { get; set; }
    }
}
