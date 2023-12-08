namespace IIT.BLL.DTOs.Users
{
    public class UserTypeDTO
    {
        public int UserTypeId { get; set; }
        public string TypeName { get; set; }
        public ICollection<UserDTO> Users { get; set; }
    }
}
