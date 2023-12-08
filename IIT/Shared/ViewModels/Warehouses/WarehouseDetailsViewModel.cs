namespace IIT.Shared.ViewModels.Warehouses
{
    public class WarehouseDetailsViewModel
    {
        public int WarehouseDetailsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public double Size { get; set; }
        public WarehouseTypeViewModel? WarehouseType { get; set; }
        public int WarehouseId { get; set; }
        public WarehouseViewModel Warehouse { get; set; }
    }
}
