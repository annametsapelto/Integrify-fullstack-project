namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class AuthorDTO : BaseDTO<Author>
{
    [MinLength(2)]
    public string FirstName { get; set; } = null!;
    [MinLength(2)]
    public string LastName { get; set; } = null!;
    public IList<Book> Books { get; set; } = null!;
    public string? Biography { get; set; }

    public override void UpdateModel(Author model)
    {
        model.FirstName = FirstName;
        model.LastName = LastName;
        model.Books = Books;
        model.Biography = Biography;
    }
}