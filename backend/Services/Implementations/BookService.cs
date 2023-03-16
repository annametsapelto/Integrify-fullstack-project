namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;

public class BookService : DbCrudService<Book, BookDTO>, IBookService
{
    public BookService(AppDbContext dbContext) : base(dbContext)
    {
    }
}