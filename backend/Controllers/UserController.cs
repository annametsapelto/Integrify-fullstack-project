namespace Controllers;

using Services;
using Models;
using DTOs;
using Microsoft.AspNetCore.Mvc;

public class UserController : CrudController<User, UserCreateDTO, UserReadDTO, UserUpdateDTO>
{
    private readonly IUserService _service;

    public UserController(IUserService service) : base(service)
    {
        _service = service;
    }

[HttpPost("/signup")]
    public async Task<IActionResult> SignUpAsync(UserSignUpDTO request)
    {
        var user = await _service.SignUpAsync(request);
        if (user is null)
        {
            return BadRequest();
        }
        return Ok(user);
    }
}