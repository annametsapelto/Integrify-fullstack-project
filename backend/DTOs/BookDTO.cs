namespace DTOs;

using Models;

public class BookDTO : BaseDTO<Book>
{
    public string Title { get; set; } = null!;
    public IList<Author> Authors { get; set; } = null!;
    public Genre Genre { get; set; } = null!;
    public Genre? SubGenre { get; set; }
    public string? Publisher { get; set; }
    public int PublishingYear { get; set; }
    public int PageCount { get; set; }
    public decimal Price { get; set; }
    public int StorageTotal { get; set; }
    public override void UpdateModel(Book model)
    {
        model.Title = Title;
        model.Authors = Authors;
        model.Genre = Genre;
        model.SubGenre = SubGenre;
        model.Publisher = Publisher;
        model.PublishingYear = PublishingYear;
        model.PageCount = PageCount;
        model.Price = Price;
        model.StorageTotal = StorageTotal;
    }
}