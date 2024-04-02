using KitobNur.Service.Configurations;
using KitobNur.Service.Dtos.Books.BestselerBooks;

namespace KitobNur.Service.Interfaces.Books;

public interface IBestsellerBookService
{
    Task<bool> RemoveAsync(long id);
    Task<BestsellerBookForResultDto> RetrieveByIdAsync(long id);
    Task<BestsellerBookForResultDto> CreateAsync(BestsellerBookDto dto);
    Task<BestsellerBookForResultDto> ModifyAsync(long id, BestsellerBookDto dto);
    Task<IEnumerable<BestsellerBookForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
