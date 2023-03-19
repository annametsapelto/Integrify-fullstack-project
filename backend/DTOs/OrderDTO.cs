namespace DTOs;

using Models;

public class BaseOrderDTO
{
    public IList<Book> Items {get; set; } = null!;
    public decimal Total { get; set; }
    public User Orderer { get; set; } = null!;
}

public class OrderCreateDTO
{}

public class OrderReadDTO
{}

public class OrderUpdateDTO
{}