namespace Controllers;

using Services;
using Models;
using DTOs;
using Microsoft.AspNetCore.Mvc;

public class OrderController : CrudController<Order, OrderDTO>
{
    private readonly IOrderService _service;

    public OrderController(IOrderService service) : base(service)
    {
        _service = service;
    }
}