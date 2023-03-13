namespace Controllers;

using Services;
using Models;
using DTOs;
using Microsoft.AspNetCore.Mvc;

public class UserController : CrudController<User, UserDTO>
{
    private readonly IUserService _service;

    public UserController(IUserService service) : base(service)
    {
        _service = service;
    }
}