using KitobNur.Service.Configurations;
using KitobNur.Service.Dtos.Books.InitBooks;

namespace KitobNur.Service.Interfaces.Books;

public interface IInitBookService
{
    Task<bool> RemoveAsync(long id);
    Task<InitBookForResultDto> RetrieveByIdAsync(long id);
    Task<InitBookForResultDto> CreateAsync(InitBookDto dto);
    Task<InitBookForResultDto> ModifyAsync(long id, InitBookDto dto);
    Task<IEnumerable<InitBookForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
