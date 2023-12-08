using IIT.DAL.Entities.Warehouses;
using IIT.DAL.Repositories.Interfaces.Warehouses;
using IIT.DAL.Repositories.Realizations.Base;

namespace IIT.DAL.Repositories.Realizations.Warehouses
{
    public class WarehouseTypeRepository : RepositoryBase<WarehouseType>, IWarehouseTypeRepository 
    {
        public WarehouseTypeRepository(IITDBContext dbcontext) : base(dbcontext)
        {
            
        }
    }
}
