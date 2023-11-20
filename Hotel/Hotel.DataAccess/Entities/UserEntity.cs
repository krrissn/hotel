using System.ComponentModel.DataAnnotations.Schema;


namespace Hotel.DataAccess.Entities
{
    [Table("users")]
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string PasswordHash { get; set; }

        public virtual ICollection<ReviewEntity> Reviews { get; set; }
        public virtual ICollection<ReservationEntity> Reservations { get; set; }
    }
}
