using System.ComponentModel.DataAnnotations;

namespace IIT.DAL.Entities.Users
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }
        public string TypeName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
