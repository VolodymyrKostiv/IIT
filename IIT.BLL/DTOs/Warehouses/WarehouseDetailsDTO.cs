using IIT.DAL.Entities.Warehouses;

namespace IIT.BLL.DTOs.Warehouses
{
    public class WarehouseDetailsDTO
    {
        public int WarehouseDetailsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public double Size { get; set; }
        public WarehouseTypeDTO? WarehouseType { get; set; }
        public int WarehouseId { get; set; }
        public WarehouseDTO Warehouse { get; set; }
    }
}
