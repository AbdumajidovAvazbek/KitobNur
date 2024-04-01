using KitobNur.Domain.Entities.Books;

namespace KitobNur.Service.Dtos.Rentals
{
    public class RentalForCreationDto
    {
        public long UserId { get; set; } // Foreign Key to Readers table
        public ICollection<Book> Books { get; set; }
    }
}
