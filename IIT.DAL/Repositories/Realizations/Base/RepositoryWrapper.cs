using IIT.DAL.Repositories.Interfaces.Base;
using IIT.DAL.Repositories.Interfaces.Bookings;
using IIT.DAL.Repositories.Interfaces.Users;
using IIT.DAL.Repositories.Interfaces.Warehouses;
using IIT.DAL.Repositories.Realizations.Bookings;
using IIT.DAL.Repositories.Realizations.Users;
using IIT.DAL.Repositories.Realizations.Warehouses;

namespace IIT.DAL.Repositories.Realizations.Base
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly IITDBContext _dbContext;

        private IBookingRepository _booking;
        private IBookingStatusRepository _bookingStatus;
        private IUserRepository _user;
        private IUserDetailsRepository _userDetails;
        private IUserTypeRepository _userType;
        private IWarehouseRepository _warehouse;
        private IWarehouseDetailsRepository _warehouseDetails;
        private IWarehouseTypeRepository _warehouseType;

        public IBookingRepository BookingRepository
        {
            get
            {
                if (_booking == null)
                {
                    _booking = new BookingRepository(_dbContext);
                }

                return _booking;
            }
        }

        public IBookingStatusRepository BookingStatusRepository
        {
            get
            {
                if (_bookingStatus == null)
                {
                    _bookingStatus = new BookingStatusRepository(_dbContext);
                }

                return _bookingStatus;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_dbContext);
                }

                return _user;
            }
        }

        public IUserDetailsRepository UserDetailsRepository
        {
            get
            {
                if (_userDetails == null)
                {
                    _userDetails = new UserDetailsRepository(_dbContext);
                }

                return _userDetails;
            }
        }

        public IUserTypeRepository UserTypeRepository
        {
            get
            {
                if (_userType == null)
                {
                    _userType = new UserTypeRepository(_dbContext);
                }

                return _userType;
            }
        }

        public IWarehouseRepository WarehouseRepository
        {
            get
            {
                if (_warehouse == null)
                {
                    _warehouse = new WarehouseRepository(_dbContext);
                }

                return _warehouse;
            }
        }

        public IWarehouseDetailsRepository WarehouseDetailsRepository
        {
            get
            {
                if (_warehouseDetails == null)
                {
                    _warehouseDetails = new WarehouseDetailsRepository(_dbContext);
                }

                return _warehouseDetails;
            }
        }

        public IWarehouseTypeRepository WarehouseTypeRepository
        {
            get
            {
                if (_warehouseType == null)
                {
                    _warehouseType = new WarehouseTypeRepository(_dbContext);
                }

                return _warehouseType;
            }
        }

        public RepositoryWrapper(IITDBContext ICHDBContext)
        {
            _dbContext = ICHDBContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
