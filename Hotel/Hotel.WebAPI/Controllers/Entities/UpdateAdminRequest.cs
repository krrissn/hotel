﻿
namespace Hotel.WebAPI.Controllers.Entities
{
    public class UpdateAdminRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
