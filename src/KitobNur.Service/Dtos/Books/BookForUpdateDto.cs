namespace KitobNur.Service.Dtos.Books;

public class BookForUpdateDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Author { get; set; }
    public short Count { get; set; }
    public decimal Balance { get; set; }
    public string ImagePath { get; set; }
    public int CategoryId { get; set; }
}
