namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;

public class AuthorService : DbCrudService<Author, AuthorDTO>, IAuthorService
{
    public AuthorService(AppDbContext dbContext) : base(dbContext)
    {
    }
}
