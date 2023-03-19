namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using AutoMapper;
using Repositories;

public class UserService : DbCrudService<User, UserCreateDTO, UserReadDTO, UserUpdateDTO>, IUserService
{
    public UserService(IMapper mapper, IUserRepository repo) : base(mapper, repo)
    {
    }
}