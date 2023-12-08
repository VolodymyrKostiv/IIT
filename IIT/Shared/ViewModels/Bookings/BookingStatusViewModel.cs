namespace IIT.Shared.ViewModels.Bookings
{
    public class BookingStatusViewModel
    {
        public int BookingStatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<BookingViewModel> Bookings { get; set; }
    }
}
