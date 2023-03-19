namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;
using AutoMapper;
using Repositories;

public class GenreService : DbCrudService<Genre, GenreCreateDTO, GenreReadDTO, GenreUpdateDTO>, IGenreService
{
    public GenreService(IMapper mapper, IGenreRepository repo) : base(mapper, repo)
    {
    }
}