﻿
namespace Hotel.BL.HotelRooms.Entities
{
    public class HotelRoomModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int NumberOfGuests { get; set; }
        public int Price { get; set; }
        public int HotelId { get; set; }
    }
}
