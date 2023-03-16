namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using Database;

public class UserService : DbCrudService<User, UserDTO>, IUserService
{
    public UserService(AppDbContext dbContext) : base(dbContext)
    {
    }
}