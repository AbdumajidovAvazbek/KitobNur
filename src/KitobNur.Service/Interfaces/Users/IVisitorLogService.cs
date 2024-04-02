using KitobNur.Service.Configurations;
using KitobNur.Service.Dtos.VisitorLogs;

namespace KitobNur.Service.Interfaces.Users;

public interface IVisitorLogService
{
    Task<bool> RemoveAsync(long id);
    Task<VisitorLogForResultDto> RetrieveByIdAsync(long id);
    Task<VisitorLogForResultDto> CreateAsync(VisitorLogForCreationDto dto);
    Task<VisitorLogForResultDto> ModifyAsync(long id, VisitorLogForUpdateDto dto);
    Task<IEnumerable<VisitorLogForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
