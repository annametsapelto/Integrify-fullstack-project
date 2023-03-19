namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class BaseAuthorDTO
{
    [MinLength(2)]
    public string FirstName { get; set; } = null!;
    [MinLength(2)]
    public string LastName { get; set; } = null!;
    public IList<Book> Books { get; set; } = null!;
    public string? Biography { get; set; }
}

public class AuthorCreateDTO : BaseAuthorDTO
{}

public class AuthorReadDTO : BaseAuthorDTO
{}

public class AuthorUpdateDTO : BaseAuthorDTO
{}