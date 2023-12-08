using IIT.BLL.DTOs.Warehouses;

namespace IIT.BLL.Services.Interfaces.Warehouses
{
    public interface IWarehouseService
    {
        Task<IEnumerable<WarehouseDTO>> GetAllWarehousesAsync();
    }
}
