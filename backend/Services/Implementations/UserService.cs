namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using AutoMapper;
using Repositories;
using System.Threading.Tasks;

public class UserService : DbCrudService<User, UserCreateDTO, UserReadDTO, UserUpdateDTO>, IUserService
{
    public UserService(IMapper mapper, IUserRepository repo) : base(mapper, repo)
    {
    }

    public Task<User> SignUpAsync(UserSignUpDTO request)
    {
        throw new NotImplementedException();
    }
}