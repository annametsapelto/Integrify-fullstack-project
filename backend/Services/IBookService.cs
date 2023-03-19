namespace Services;

using Models;
using DTOs;

public interface IBookService : ICrudService<Book, BookCreateDTO, BookReadDTO, BookUpdateDTO>
{
    
}