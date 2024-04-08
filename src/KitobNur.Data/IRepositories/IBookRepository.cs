using KitobNur.Domain.Entities.Books;

namespace KitobNur.Data.IRepositories;

public interface IBookRepository : IRepository<Book, long>
{
}
