using KitobNur.Domain.Entities.Books;

namespace KitobNur.Service.Dtos.VisitorLogs;

public class VisitorLogForCreationDto
{
    public long UserId { get; set; }
    public ICollection<Book> Books { get; set; }
}
