namespace Services;

using Models;
using DTOs;

public interface IUserService : ICrudService<User, UserCreateDTO, UserReadDTO, UserUpdateDTO>
{
    
}