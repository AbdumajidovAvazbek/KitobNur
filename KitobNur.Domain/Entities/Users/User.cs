using KitobNur.Domain.Comon;

namespace KitobNur.Domain.Users
{
    public class User : Auditable<long>
    {
        public string UserName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string? TelegramId { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportNumber { get; set; }
        public string? WorkPlace { get; set; }
        public string? StudyPlaces { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
    }
}
