using KitobNur.Domain.Comon;
using KitobNur.Domain.Users;
using KitobNur.Domain.Entities.Books;

namespace KitobNur.Domain.Library
{
    public class Rental : Auditable<long>
    {

        public long UserId { get; set; } // Foreign Key to Readers table
        public User User { get; set; } // Navigation property

        public ICollection<Book> Books { get; set; }

    }
}
