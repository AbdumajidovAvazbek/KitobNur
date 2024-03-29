using KitobNur.Domain.Comon;

namespace KitobNur.Domain.Entities.Books;

public class OrderBook : Auditable<long>
{
    public string Name { get; set; }
}
