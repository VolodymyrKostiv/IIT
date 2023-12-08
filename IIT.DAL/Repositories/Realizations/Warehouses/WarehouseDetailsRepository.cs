using IIT.DAL.Entities.Warehouses;
using IIT.DAL.Repositories.Interfaces.Warehouses;
using IIT.DAL.Repositories.Realizations.Base;

namespace IIT.DAL.Repositories.Realizations.Warehouses
{
    public class WarehouseDetailsRepository : RepositoryBase<WarehouseDetails>, IWarehouseDetailsRepository 
    {
        public WarehouseDetailsRepository(IITDBContext dbcontext) : base(dbcontext)
        {
            
        }
    }
}
