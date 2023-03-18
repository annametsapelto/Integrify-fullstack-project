namespace Repositories;

using Database;
using Models;

public class BookRepository : BaseRepository<Book>, IBookRepository
{
    public BookRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}