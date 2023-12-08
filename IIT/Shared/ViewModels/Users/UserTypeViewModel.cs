namespace IIT.Shared.ViewModels.Users
{
    public class UserTypeViewModel
    {
        public int UserTypeId { get; set; }
        public string TypeName { get; set; }
        public ICollection<UserViewModel> Users { get; set; }
    }
}
