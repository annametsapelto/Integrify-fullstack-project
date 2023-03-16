namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;

public class OrderService : DbCrudService<Order, OrderDTO>, IOrderService
{
    public OrderService(AppDbContext dbContext) : base(dbContext)
    {
    }
}