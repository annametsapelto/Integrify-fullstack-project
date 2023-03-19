namespace Controllers;

using Services;
using Models;
using DTOs;
using Microsoft.AspNetCore.Mvc;

public class GenreController : CrudController<Genre, GenreCreateDTO, GenreReadDTO, GenreUpdateDTO>
{
    private readonly IGenreService _service;

    public GenreController(IGenreService service) : base(service)
    {
        _service = service;
    }
}