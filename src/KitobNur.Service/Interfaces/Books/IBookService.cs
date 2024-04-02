using KitobNur.Service.Dtos.Books;
using KitobNur.Service.Configurations;

namespace KitobNur.Service.Interfaces.Books;

public interface IBookService
{
    Task<bool> RemoveAsync(long id);
    Task<BookForResultDto> RetrieveByIdAsync(long id);
    Task<BookForResultDto> CreateAsync(BookForCreationDto dto);
    Task<BookForResultDto> ModifyAsync(long id, BookForUpdateDto dto);
    Task<IEnumerable<BookForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
