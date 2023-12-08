using AutoMapper;
using IIT.BLL.DTOs.Users;
using IIT.DAL.Entities.Users;

namespace IIT.BLL.Mapping.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<UserDetails, UserDetailsDTO>().ReverseMap();
            CreateMap<UserType, UserTypeDTO>().ReverseMap();
        }
    }
}
