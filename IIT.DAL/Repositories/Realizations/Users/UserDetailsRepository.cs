using IIT.DAL.Entities.Users;
using IIT.DAL.Repositories.Interfaces.Users;
using IIT.DAL.Repositories.Realizations.Base;

namespace IIT.DAL.Repositories.Realizations.Users
{
    public class UserDetailsRepository : RepositoryBase<UserDetails>, IUserDetailsRepository
    {
        public UserDetailsRepository(IITDBContext dbcontext) : base(dbcontext)
        {
            
        }
    }
}
