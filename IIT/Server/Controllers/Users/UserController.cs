using AutoMapper;
using IIT.BLL.DTOs.Users;
using IIT.BLL.Services.Interfaces.Users;
using IIT.Shared.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace IIT.Server.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost("GetUser")]
        public async Task<IActionResult> GetUser([FromBody] UserLoginCredentialsViewModel userCreds)
        {
            if (string.IsNullOrEmpty(userCreds.Username) || string.IsNullOrEmpty(userCreds.Password))
            {
                return NotFound(new { Message = "Invalid Login or Password" });
            }

            var mappedCreds = _mapper.Map<UserLoginCredentialsDTO>(userCreds);

            var user = await _userService.GetUserByCredentialAsync(mappedCreds);

            if (user == null)
            {
                return NotFound(new { Message = "Invalid Login or Password" });
            }

            var mappedUser = _mapper.Map<UserViewModel>(user);

            return Ok(mappedUser);
        }
    }
}
