using KitobNur.Domain.Enum;

namespace KitobNur.Service.Dtos.Users;

public class UserForResultDto
{
    public long Id { get; set; }
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
    public GenderType GenderType { get; set; }
    public UserStatus userStatus { get; set; }
    public UserType userType { get; set; }
}
