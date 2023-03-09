namespace Models;

public class Book : BaseModel
{
    public string Title { get; set; } = null!;
    public IList<Author> Authors { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public string? Publisher { get; set; }
    public int PublishingYear { get; set; }
    public int PageCount { get; set; }
    public decimal Price { get; set; }
    public int StorageTotal { get; set; }
}