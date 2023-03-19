namespace Api;

using DTOs;
using Models;
using AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<User, UserReadDTO>();
        CreateMap<UserUpdateDTO, User>();
        CreateMap<UserCreateDTO, User>();
    }
}
