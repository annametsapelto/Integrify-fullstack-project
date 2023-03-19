namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using AutoMapper;
using Repositories;

public class AuthorService : DbCrudService<Author, AuthorCreateDTO, AuthorReadDTO, AuthorUpdateDTO>, IAuthorService
{
    public AuthorService(IMapper mapper, AuthorRepository repo) : base(mapper, repo)
    {
    }
}
