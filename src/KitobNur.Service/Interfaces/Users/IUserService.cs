using Microsoft.AspNetCore.Http;
using KitobNur.Service.Dtos.Users;
using KitobNur.Service.Configurations;
using KitobNur.Domain.Enum;

namespace KitobNur.Service.Interfaces.Users;

public interface IUserService
{
    Task<bool> RemoveAsync(long id);
    Task<UserForResultDto> RetrieveByIdAsync(long id);
    Task<UserForResultDto> CreateAsync(UserForCreationDto dto);
    Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto);
    Task<IEnumerable<UserForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<UserForResultDto> ModifyUserStatusAsync(long id, UserStatus userStatus);
    Task<bool> UserTypeUpdateAsync(long id, UserType userType);
    Task<bool> UploadPhotoAsync(long id, IFormFile photoPath);
}
