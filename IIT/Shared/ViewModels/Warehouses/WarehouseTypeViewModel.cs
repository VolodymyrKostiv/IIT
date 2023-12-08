namespace IIT.Shared.ViewModels.Warehouses
{
    public class WarehouseTypeViewModel
    {
        public int WarehouseTypeId { get; set; }
        public string TypeName { get; set; }
        public ICollection<WarehouseDetailsViewModel> WarehouseDetails { get; set; }
    }
}
