namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;

public class GenreService : DbCrudService<Author, AuthorDTO>, IAuthorService
{
    public GenreService(AppDbContext dbContext) : base(dbContext)
    {
    }
}