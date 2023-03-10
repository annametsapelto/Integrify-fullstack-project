namespace DTOs;

using Models;

public class OrderDTO : BaseDTO<Order>
{
    public IList<Book> Items {get; set; } = null!;
    public decimal Total { get; set; }
    public override void UpdateModel(Order model)
    {
        model.Items = Items;
        model.Total = Total;
    }
}