using IIT.DAL.Entities.Users;
using IIT.DAL.Repositories.Interfaces.Users;
using IIT.DAL.Repositories.Realizations.Base;

namespace IIT.DAL.Repositories.Realizations.Users
{
    public class UserTypeRepository : RepositoryBase<UserType>, IUserTypeRepository
    {
        public UserTypeRepository(IITDBContext dbcontext) : base(dbcontext)
        {
            
        }
    }
}
