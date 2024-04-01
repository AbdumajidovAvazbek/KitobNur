using KitobNur.Domain.Comon;

namespace KitobNur.Domain.Entities.Categories;

public class Category:Auditable<int>
{
    public string Name { get; set; }
}
