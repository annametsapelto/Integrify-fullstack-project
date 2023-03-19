namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;
using AutoMapper;
using Repositories;

public class OrderService : DbCrudService<Order, OrderCreateDTO, OrderReadDTO, OrderUpdateDTO>, IOrderService
{
    public OrderService(IMapper mapper, IOrderRepository repo) : base(mapper, repo)
    {
    }
}