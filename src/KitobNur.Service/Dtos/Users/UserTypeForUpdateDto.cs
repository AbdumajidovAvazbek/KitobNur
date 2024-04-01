using KitobNur.Domain.Enum;

namespace KitobNur.Service.Dtos.Users;

public class UserTypeForUpdateDto
{
    public long UserId { get; set; }
    public UserType UserType { get; set; }
}
