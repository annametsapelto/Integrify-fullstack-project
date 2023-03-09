namespace Models;

public class Author : BaseModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public IList<Book> Books { get; set; } = null!;
    public string? Biography { get; set; }
}