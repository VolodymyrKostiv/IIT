namespace IIT.Shared.ViewModels.Users
{
    public class UserDetailsViewModel
    {
        public int UserDetailsId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int UserId { get; set; }
        public UserViewModel User { get; set; }
    }
}
