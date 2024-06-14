using KitobNur.Domain.Comon;
using KitobNur.Domain.Users;
using KitobNur.Domain.Entities.Books;
namespace KitobNur.Domain.Entities.Users;
public class VistorLog : Auditable<long>
{
    public long UserId { get; set; }
    public User User { get; set; }
    public long BookId { get; set; }
    public Book Book { get; set; }
}
