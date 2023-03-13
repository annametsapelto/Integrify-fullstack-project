namespace Controllers;

using Services;
using Models;
using DTOs;
using Microsoft.AspNetCore.Mvc;

public class AuthorController : CrudController<Author, AuthorDTO>
{
    private readonly IAuthorService _service;

    public AuthorController(IAuthorService service) : base(service)
    {
        _service = service;
    }
}