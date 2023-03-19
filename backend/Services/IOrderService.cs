namespace Services;

using Models;
using DTOs;

public interface IOrderService : ICrudService<Order, OrderCreateDTO, OrderReadDTO, OrderUpdateDTO>
{
    
}