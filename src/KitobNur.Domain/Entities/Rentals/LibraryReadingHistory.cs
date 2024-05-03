using KitobNur.Domain.Comon;
using KitobNur.Domain.Entities.Books;
using KitobNur.Domain.Users;

namespace KitobNur.Domain.Entities.Rentals;

public class LibraryReadingHistory : Auditable<long>
{
    public long UserId { get; set; } // Foreign Key to Readers table
    public User User { get; set; } // Navigation property
    public ICollection<Book> Books { get; set; }
}
