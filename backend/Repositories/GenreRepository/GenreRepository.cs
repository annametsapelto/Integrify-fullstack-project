namespace Repositories;

using Database;
using Models;

public class GenreRepository : BaseRepository<Genre>, IGenreRepository
{
    public GenreRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}