namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;

public class OrderService : DbCrudService<Author, AuthorDTO>, IAuthorService
{
    public OrderService(AppDbContext dbContext) : base(dbContext)
    {
    }
}