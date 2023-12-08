using IIT.DAL.Entities.Users;
using IIT.DAL.Repositories.Interfaces.Users;
using IIT.DAL.Repositories.Realizations.Base;

namespace IIT.DAL.Repositories.Realizations.Users
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IITDBContext dbcontext) : base(dbcontext)
        {
            
        }
    }
}
