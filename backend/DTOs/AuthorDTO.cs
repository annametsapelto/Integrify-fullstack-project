namespace DTOs;

using Models;

public class AuthorDTO : BaseDTO<Author>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public IList<Book> Books { get; set; } = null!;
    public string? Biography { get; set; }

    public override void UpdateModel(Author model)
    {
        throw new NotImplementedException();
    }
}