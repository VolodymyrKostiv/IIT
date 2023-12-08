using IIT.Shared.ViewModels.Bookings;

namespace IIT.Shared.ViewModels.Warehouses
{
    public class WarehouseViewModel
    {
        public int WarehouseId { get; set; }
        public WarehouseTypeViewModel WarehouseType { get; set; }
        public WarehouseDetailsViewModel WarehouseDetails { get; set; }
        public ICollection<BookingViewModel> Bookings { get; set; }
    }
}
