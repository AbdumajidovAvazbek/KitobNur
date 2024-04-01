using KitobNur.Domain.Comon;

namespace KitobNur.Domain.Entities.Books;

public class InitBook : Auditable<long>
{
    public string Name { get; set; }
    public long BookId { get; set; }
    public Book Book { get; set; }

}
