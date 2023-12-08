namespace IIT.BLL.DTOs.Warehouses
{
    public class WarehouseTypeDTO
    {
        public int WarehouseTypeId { get; set; }
        public string TypeName { get; set; }
        public ICollection<WarehouseDetailsDTO> WarehouseDetails { get; set; }
    }
}
