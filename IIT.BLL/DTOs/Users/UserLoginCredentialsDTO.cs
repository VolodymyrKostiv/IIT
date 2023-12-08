namespace IIT.BLL.DTOs.Users
{
    public class UserLoginCredentialsDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserLoginCredentialsDTO model &&
                   Username == model.Username &&
                   Password == model.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Username, Password);
        }
    }
}
