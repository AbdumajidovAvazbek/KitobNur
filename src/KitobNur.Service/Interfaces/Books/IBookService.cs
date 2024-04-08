using KitobNur.Service.Dtos.Books;
using KitobNur.Service.Configurations;
using Microsoft.AspNetCore.Http;

namespace KitobNur.Service.Interfaces.Books;

public interface IBookService
{
    Task<bool> RemoveAsync(long id);
    Task<BookForResultDto> RetrieveByIdAsync(long id);
    Task<BookForResultDto> RetrieveByNameAsync(string name);
    Task<BookForResultDto> RetrieveByAuthorAsync(string author);

    Task<BookForResultDto> CreateAsync(BookForCreationDto dto,IFormFile fromFile);
    Task<BookForResultDto> ModifyAsync(long id, BookForUpdateDto dto);
    Task<IEnumerable<BookForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
