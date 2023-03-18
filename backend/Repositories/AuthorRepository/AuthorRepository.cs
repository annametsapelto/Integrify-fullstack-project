namespace Repositories;

using Database;
using Models;

public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
{
    public AuthorRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}