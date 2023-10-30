namespace Hotel.WebAPI.Settings
{
    public static class HotelSettingsReader
    {
        public static HotelSettings Read(IConfiguration configuration)
        {
            return new HotelSettings();
        }
    }
}
