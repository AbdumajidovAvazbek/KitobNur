using KitobNur.Domain.Comon;

namespace KitobNur.Domain.Entities.Categories;

public class Categories:Auditable<int>
{
    public string Name { get; set; }
}
