namespace IIT.BLL.DTOs.Bookings
{
    public class BookingStatusDTO
    {
        public int BookingStatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<BookingDTO> Bookings { get; set; }
    }
}
