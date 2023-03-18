namespace Repositories;

using Database;
using Models;

public class AddressRepository : BaseRepository<Address>, IAddressRepository
{
    public AddressRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}