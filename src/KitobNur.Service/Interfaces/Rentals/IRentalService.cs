using KitobNur.Service.Configurations;
using KitobNur.Service.Dtos.Rentals;

namespace KitobNur.Service.Interfaces.Rentals;

public interface IRentalService
{
    Task<bool> RemoveAsync(long id);
    Task<RentalForResultDto> RetrieveByIdAsync(long id);
    Task<RentalForResultDto> CreateAsync(RentalForCreationDto dto);
    Task<IEnumerable<RentalForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
