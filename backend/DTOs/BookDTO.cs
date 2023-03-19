namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class BaseBookDTO
{
    [MinLength(2)]
    public string Title { get; set; } = null!;
    public IList<Author> Authors { get; set; } = null!;
    public Genre Genre { get; set; } = null!;
    public Genre? SubGenre { get; set; }
    public string? Publisher { get; set; }
    public int PublishingYear { get; set; }
    public int PageCount { get; set; }
    public decimal Price { get; set; }
    public int StorageTotal { get; set; }
}

public class BookCreateDTO : BaseBookDTO
{}

public class BookReadDTO : BaseBookDTO
{}

public class BookUpdateDTO : BaseBookDTO
{}