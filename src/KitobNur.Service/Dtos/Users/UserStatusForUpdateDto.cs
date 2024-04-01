using KitobNur.Domain.Enum;

namespace KitobNur.Service.Dtos.Users;

public class UserStatusForUpdateDto
{
    public long UserId { get; set; }
    public UserStatus UserStatus { get; set; }
}
