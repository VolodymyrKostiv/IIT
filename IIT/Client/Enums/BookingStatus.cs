using System.ComponentModel;

namespace IIT.Client.Enums
{
    public enum BookingStatus
    {
        [Description("Pending")]
        Pending = 1,
        [Description("Cancelled")]
        Cancelled = 2,
        [Description("Completed")]
        Completed = 3,
        [Description("Expired")]
        Expired = 4,
    }
}
