using KitobNur.Domain.Comon;
using KitobNur.Domain.Entities.Categories;
using KitobNur.Domain.Enum;

namespace KitobNur.Domain.Entities.Books;

public class Book : Auditable<long>
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Author { get; set; }
    public short Count { get; set; }  
    public decimal Balance { get; set; }
    public string ImagePath { get; set; }
    public int CategoryId { get; set; }
    public Category category { get; set; }
    public BookStatus Status { get; set; }

}
