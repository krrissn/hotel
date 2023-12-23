using Hotel.BL.Admin;
using Hotel.BL.HotelRooms;
using Hotel.BL.User;
using Hotel.DataAccess;

namespace Hotel.WebAPI.IoC
{
    public class ServicesConfigurator
    {
        public static void ConfigureService(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAdminsProvider, AdminsProvider>();
            services.AddScoped<IAdminsManager, AdminsManager>();
            services.AddScoped<IHotelRoomsProvider, HotelRoomsProvider>();
            services.AddScoped<IHotelRoomsManager, HotelRoomsManager>();
            services.AddScoped<IUsersProvider, UsersProvider>();
            services.AddScoped<IUsersManager, UsersManager>();
        }
    }
}
