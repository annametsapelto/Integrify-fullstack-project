namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;

public class UserService : DbCrudService<Author, AuthorDTO>, IAuthorService
{
    public UserService(AppDbContext dbContext) : base(dbContext)
    {
    }
}