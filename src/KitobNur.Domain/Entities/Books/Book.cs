using KitobNur.Domain.Comon;
using KitobNur.Domain.Entities.Categories;

namespace KitobNur.Domain.Entities.Books;

public class Book : Auditable<long>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public short counte { get; set; }  
    public decimal Balance { get; set; }
    public string ImagePath { get; set; }
    public int CategoryId { get; set; }
    public Category category { get; set; }

}
