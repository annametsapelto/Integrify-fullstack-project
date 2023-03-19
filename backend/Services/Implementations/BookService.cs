namespace Services;

using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;
using AutoMapper;
using Repositories;

public class BookService : DbCrudService<Book, BookCreateDTO, BookReadDTO, BookUpdateDTO>, IBookService
{

public BookService(IMapper mapper, IBookRepository repo) : base(mapper, repo)
    {
    }
}