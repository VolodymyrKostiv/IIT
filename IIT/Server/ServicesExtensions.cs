using IIT.DAL.Repositories.Interfaces.Base;
using IIT.DAL.Repositories.Interfaces.Bookings;
using IIT.DAL.Repositories.Interfaces.Users;
using IIT.DAL.Repositories.Interfaces.Warehouses;
using IIT.DAL.Repositories.Realizations.Base;
using IIT.DAL.Repositories.Realizations.Bookings;
using IIT.DAL.Repositories.Realizations.Users;
using IIT.DAL.Repositories.Realizations.Warehouses;

namespace IIT.Server
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingStatusRepository, BookingStatusRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserDetailsRepository, UserDetailsRepository>();
            services.AddScoped<IUserTypeRepository, UserTypeRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();
            services.AddScoped<IWarehouseDetailsRepository, WarehouseDetailsRepository>();
            services.AddScoped<IWarehouseTypeRepository, WarehouseTypeRepository>();

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            return services;
        }
    }
}
