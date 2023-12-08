using IIT.DAL.Repositories.Interfaces.Bookings;
using IIT.DAL.Repositories.Interfaces.Users;
using IIT.DAL.Repositories.Interfaces.Warehouses;

namespace IIT.DAL.Repositories.Interfaces.Base
{
    public interface IRepositoryWrapper
    {
        IBookingRepository BookingRepository { get; }
        IBookingStatusRepository BookingStatusRepository { get; }
        IUserRepository UserRepository { get; }
        IUserDetailsRepository UserDetailsRepository { get; }
        IUserTypeRepository UserTypeRepository { get; }
        IWarehouseRepository WarehouseRepository { get; }
        IWarehouseDetailsRepository WarehouseDetailsRepository { get; }
        IWarehouseTypeRepository WarehouseTypeRepository { get; }

        void Save();
        Task SaveAsync();
    }
}
