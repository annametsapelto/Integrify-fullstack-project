namespace Services;

using Models;
using DTOs;

public interface IAuthorService : ICrudService<Author, AuthorCreateDTO, AuthorReadDTO, AuthorUpdateDTO>
{
    
}