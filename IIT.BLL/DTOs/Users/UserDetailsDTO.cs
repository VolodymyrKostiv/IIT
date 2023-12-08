namespace IIT.BLL.DTOs.Users
{
    public class UserDetailsDTO
    {
        public int UserDetailsId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
    }
}
