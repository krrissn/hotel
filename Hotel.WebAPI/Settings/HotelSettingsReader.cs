namespace Hotel.WebAPI.Settings
{
    public static class HotelSettingsReader
    {
        public static HotelSettings Read(IConfiguration configuration)
        {
            //здесь будет чтение настроек приложения из конфига
            return new HotelSettings()
            {
                HotelDbContextConnectionString = configuration.GetValue<string>("HotelDbContext")
            };
        }
    }
}
