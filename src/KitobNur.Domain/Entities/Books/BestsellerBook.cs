using KitobNur.Domain.Comon;

namespace KitobNur.Domain.Entities.Books;

public class BestsellerBook : Auditable<int>
{
    public string Name { get; set; }
}
