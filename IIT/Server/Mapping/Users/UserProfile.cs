using AutoMapper;
using IIT.BLL.DTOs.Users;
using IIT.Shared.ViewModels.Users;

namespace IIT.Server.Mapping.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDTO, UserViewModel>().ReverseMap();
            CreateMap<UserDetailsDTO, UserDetailsViewModel>().ReverseMap();
            CreateMap<UserTypeDTO, UserTypeViewModel>().ReverseMap();
            CreateMap<UserLoginCredentialsDTO, UserLoginCredentialsViewModel>().ReverseMap();
        }
    }
}
