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
        CreateMap<Author, AuthorReadDTO>();
        CreateMap<AuthorUpdateDTO, Author>();
        CreateMap<AuthorCreateDTO, Author>();
        CreateMap<Book, BookReadDTO>();
        CreateMap<BookUpdateDTO, Book>();
        CreateMap<BookCreateDTO, Book>();
        CreateMap<Genre, GenreReadDTO>();
        CreateMap<GenreUpdateDTO, Genre>();
        CreateMap<GenreCreateDTO, Genre>();
        CreateMap<Order, OrderReadDTO>();
        CreateMap<OrderUpdateDTO, Order>();
        CreateMap<OrderCreateDTO, Order>();
    }
}
