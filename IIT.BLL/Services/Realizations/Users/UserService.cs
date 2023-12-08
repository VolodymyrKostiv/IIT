using AutoMapper;
using IIT.BLL.DTOs.Users;
using IIT.BLL.Services.Interfaces.Users;
using IIT.DAL.Repositories.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace IIT.BLL.Services.Realizations.Users
{
    public class UserService : IUserService
    {
        private readonly IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;

        public UserService(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            _repoWrapper = repoWrapper;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _repoWrapper.UserRepository.GetAllAsync(
                include: source => source
                    .Include(x => x.UserDetails)
                    .Include(x => x.Password)
                    .Include(x => x.Login)
                    .Include(x => x.UserType));

            var mappedUsers = _mapper.Map<IEnumerable<UserDTO>>(users);

            return mappedUsers;
        }

        public async Task<UserDTO> GetUserByCredentialAsync(UserLoginCredentialsDTO creds)
        {
            var user = await _repoWrapper.UserRepository.GetFirstOrDefaultAsync(
                   include: source => source
                       .Include(x => x.UserDetails),
                   predicate: p => p.Login == creds.Username &&
                       p.Password == creds.Password);

            var mappedUser = _mapper.Map<UserDTO>(user);

            return mappedUser;
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _repoWrapper.UserRepository.GetFirstOrDefaultAsync(
                include: source => source
                    .Include(x => x.UserDetails)
                    .Include(x => x.Password)
                    .Include(x => x.Login).Include(x => x.UserType),
                predicate: p => p.UserId == id);

            var mappedUser = _mapper.Map<UserDTO>(user);

            return mappedUser;
        }

        public async Task<UserDTO> GetUserByUserTypeAsync(UserTypeDTO type)
        {
            var user = await _repoWrapper.UserRepository.GetFirstOrDefaultAsync(
                include: source => source
                    .Include(x => x.UserDetails)
                    .Include(x => x.Password)
                    .Include(x => x.Login).Include(x => x.UserType),
                predicate: p => p.UserType.UserTypeId == type.UserTypeId);

            var mappedUser = _mapper.Map<UserDTO>(user);

            return mappedUser;
        }
    }
}
