namespace KitobNur.Service.Dtos.Books;

public class BookForCreationDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Author { get; set; }
    public short counte { get; set; }
    public decimal Balance { get; set; }
    public string ImagePath { get; set; }
    public int CategoryId { get; set; }
}
