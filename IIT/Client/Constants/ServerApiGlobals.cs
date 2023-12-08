namespace IIT.Client.Constants
{
    internal static class Globals
    {
        public static string ApiUri { get; set; }
        = "https://localhost:7059/api";
    }

    internal static class UserGlobals
    {
        private static string UserUri { get; } = Globals.ApiUri + "/User";
        public static string GetUser { get; } = UserUri + "/GetUser";
        public static string GetAllUsers { get; } = UserUri + "/GetAllUsers";
        public static string LoginUserUri { get; } = UserUri + "/LoginUser";
    }

    internal static class WarehouseGlobals
    {
        private static string WarehouseUri { get; } = Globals.ApiUri + "/Warehouse";
        public static string GetWarehouse { get; } = WarehouseUri + "/GetWarehouse";
        public static string GetAllWarehouses { get; } = WarehouseUri + "/GetAllWarehouses";
    }

    internal static class BookingGlobals
    {
        private static string BookingUri { get; } = Globals.ApiUri + "/Booking";
        public static string GetBooking { get; } = BookingUri + "/GetBooking";
        public static string GetAllBookings { get; } = BookingUri + "/GetAllBookings";
    }
}
