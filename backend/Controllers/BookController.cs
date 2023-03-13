namespace Controllers;

using Services;
using Models;
using DTOs;
using Microsoft.AspNetCore.Mvc;

public class BookController : CrudController<Book, BookDTO>
{
    private readonly IBookService _service;

    public BookController(IBookService service) : base(service)
    {
        _service = service;
    }
}