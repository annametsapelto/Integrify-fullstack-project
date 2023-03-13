namespace Controllers;

using Services;
using Models;
using DTOs;
using Microsoft.AspNetCore.Mvc;

public class GenreController : CrudController<Genre, GenreDTO>
{
    private readonly IGenreService _service;

    public GenreController(IGenreService service) : base(service)
    {
        _service = service;
    }
}