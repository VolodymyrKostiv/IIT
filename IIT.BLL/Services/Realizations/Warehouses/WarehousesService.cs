using AutoMapper;
using IIT.BLL.DTOs.Warehouses;
using IIT.BLL.Services.Interfaces.Warehouses;
using IIT.DAL.Repositories.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace IIT.BLL.Services.Realizations.Warehouses
{ 
    public class WarehousesService : IWarehouseService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public async Task<IEnumerable<WarehouseDTO>> GetAllWarehousesAsync()
        {
            var warehouses = await _repoWrapper.WarehouseRepository.GetAllAsync(
                include: source => source
                    .Include(x => x.WarehouseDetails));

            var mappedWarehouses = _mapper.Map<IEnumerable<WarehouseDTO>>(warehouses);

            return mappedWarehouses;
        }
    }
}
