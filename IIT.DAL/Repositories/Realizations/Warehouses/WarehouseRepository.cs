using IIT.DAL.Entities.Warehouses;
using IIT.DAL.Repositories.Interfaces.Warehouses;
using IIT.DAL.Repositories.Realizations.Base;

namespace IIT.DAL.Repositories.Realizations.Warehouses
{
    public class WarehouseRepository : RepositoryBase<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(IITDBContext dbcontext) : base(dbcontext)
        {
            
        }
    }
}
