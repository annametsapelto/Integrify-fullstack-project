namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;

public class GenreService : DbCrudService<Genre, GenreDTO>, IGenreService
{
    public GenreService(AppDbContext dbContext) : base(dbContext)
    {
    }
}