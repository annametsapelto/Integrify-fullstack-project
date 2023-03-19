namespace Controllers;

using Services;
using Models;
using DTOs;
using Microsoft.AspNetCore.Mvc;
using Repositories;

public abstract class CrudController<TModel, TCreateDTO, TReadDTO, TUpdateDTO> : BaseApiController
    where TModel : BaseModel
{
    private readonly ICrudService<TModel, TCreateDTO, TReadDTO, TUpdateDTO> _service;

    public CrudController(ICrudService<TModel, TCreateDTO, TReadDTO, TUpdateDTO> service)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
    }

    [HttpPost()]
    public async virtual Task<IActionResult> Create(TCreateDTO request)
    {
        var item = await _service.CreateAsync(request);
        if (item is null)
        {
            return BadRequest();
        }
        return Ok(item);
    }

    [HttpGet("{id}")]
    public async virtual Task<ActionResult<TReadDTO?>> Get([FromRoute] int id)
    {
        var item = await _service.GetAsync(id);
        if (item is null)
        {
            return NotFound("Item is not found");
        }
        return Ok(item);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<TModel?>> Update(int id, TUpdateDTO request)
    {
        var item = await _service.UpdateAsync(id, request);
        if (item is null)
        {
            return NotFound("Item is not found");
        }
        return Ok(item);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        if (await _service.DeleteAsync(id))
        {
            return Ok(new { Message = "Item is deleted " });
        }
        return NotFound("Item is not found");
    }

    [HttpGet()]
    public async Task<ActionResult<ICollection<TReadDTO>>> GetAll([FromQuery] QueryOptions options)
    {
        return Ok(await _service.GetAllAsync(options));
    }
}