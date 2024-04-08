using KitobNur.Data.DbContexts;
using KitobNur.Data.IRepositories;
using KitobNur.Domain.Entities.Books;

namespace KitobNur.Data.Repositories
{
    public class BookRepository : Repository<Book, long>, IBookRepository
    {
        public BookRepository(AppDbContext context) :
            base(context)
        {
        }
    }
}
