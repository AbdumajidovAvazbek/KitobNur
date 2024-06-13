using KitobNur.Domain.Entities.Books;

namespace KitobNur.Service.Dtos.VisitorLogs;

public class VisitorLogForResultDto
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public ICollection<Book> Books { get; set; }
}
