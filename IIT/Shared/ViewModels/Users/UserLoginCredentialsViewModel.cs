
namespace IIT.Shared.ViewModels.Users
{
    public class UserLoginCredentialsViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserLoginCredentialsViewModel model &&
                   Username == model.Username &&
                   Password == model.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Username, Password);
        }
    }
}
