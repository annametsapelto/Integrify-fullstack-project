namespace Services;

using Models;
using DTOs;

public interface IGenreService : ICrudService<Genre, GenreCreateDTO, GenreReadDTO, GenreUpdateDTO>
{
    
}