﻿namespace Hotel.WebAPI.Controllers.Entities
{
    public class UpdateUserRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string PasswordHash { get; set; }
    }
}
