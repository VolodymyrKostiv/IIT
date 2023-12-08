using IIT.DAL.Entities.Bookings;
using System.ComponentModel.DataAnnotations;

namespace IIT.DAL.Entities.Warehouses
{
    public class Warehouse
    {
        [Key]
        public int WarehouseId { get; set; }
        public WarehouseDetails WarehouseDetails { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
