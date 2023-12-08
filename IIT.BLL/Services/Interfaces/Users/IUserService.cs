using IIT.BLL.DTOs.Users;
using IIT.Shared.ViewModels.Users;

namespace IIT.BLL.Services.Interfaces.Users
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByUserTypeAsync(UserTypeDTO type);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(int id);
        Task<UserDTO> GetUserByCredentialAsync(UserLoginCredentialsDTO creds);
    }
}
