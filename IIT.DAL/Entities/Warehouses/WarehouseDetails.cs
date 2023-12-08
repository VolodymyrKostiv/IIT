using System.ComponentModel.DataAnnotations;

namespace IIT.DAL.Entities.Warehouses
{
    public class WarehouseDetails
    {
        [Key]
        public int WarehouseDetailsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }    
        public double Size { get; set; }
        public WarehouseType? WarehouseType { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
