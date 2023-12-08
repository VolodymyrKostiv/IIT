using System.ComponentModel;

namespace IIT.Client.Enums
{
    public enum UserType
    {
        [Description("Admin")]
        Admin = 1,
        [Description("Customer")]
        Customer = 2,
        [Description("Landlord")]
        Landlord = 3,
    }
}
