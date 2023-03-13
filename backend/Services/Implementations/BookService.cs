namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;

public class BookService : DbCrudService<Author, AuthorDTO>, IAuthorService
{
    public BookService(AppDbContext dbContext) : base(dbContext)
    {
    }
}