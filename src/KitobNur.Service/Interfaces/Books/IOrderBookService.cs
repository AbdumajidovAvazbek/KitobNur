using KitobNur.Service.Configurations;
using KitobNur.Service.Dtos.Books.OrederBooks;

namespace KitobNur.Service.Interfaces.Books;

public interface IOrderBookService
{
    Task<bool> RemoveAsync(long id);
    Task<OrderBookForResultDto> RetrieveByIdAsync(long id);
    Task<OrderBookForResultDto> CreateAsync(OrderBookDto dto);
    Task<OrderBookForResultDto> ModifyAsync(long id, OrderBookDto dto);
    Task<IEnumerable<OrderBookForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
