namespace Models;

public class Order : BaseModel
{
    public IList<Book> Items {get; set; } = null!;
    public decimal Total { get; set; }
    public User Orderer { get; set; } = null!;
}