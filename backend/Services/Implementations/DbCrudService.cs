namespace Services;

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using Repositories;
using AutoMapper;

public class DbCrudService<TModel, TCreateDTO, TReadDTO, TUpdateDTO> 
    : ICrudService<TModel, TCreateDTO, TReadDTO, TUpdateDTO>
    where TModel : BaseModel, new()
{
    protected readonly IMapper _mapper;
    protected readonly IBaseRepository<TModel> _repo;

    public DbCrudService(IMapper mapper, IBaseRepository<TModel> repo)
    {
        _mapper = mapper;
        _repo = repo;
    }
    public async Task<TReadDTO?> CreateAsync(TCreateDTO request)
    {
        var entity = _mapper.Map<TCreateDTO, TModel>(request);
        var result = await _repo.CreateAsync(entity);
        if (result is null)
        {
            throw new Exception("Creation failed.");
        }
        return _mapper.Map<TModel, TReadDTO>(result);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id);
        if (data is null)
        {
            return false;
        }
        await _repo.DeleteAsync(id);
        return true;
    }

    public async Task<ICollection<TReadDTO>> GetAllAsync(QueryOptions options)
    {
        var data = await _repo.GetAllAsync(options);
        return _mapper.Map<ICollection<TModel>, ICollection<TReadDTO>>(data);
    }

    public async Task<TReadDTO?> GetAsync(int id)
    {
        var data = await _repo.GetAsync(id);
        if (data is null)
        {
            throw new Exception("Id not found.");
        }
        return _mapper.Map<TModel, TReadDTO>(data);
    }

    public async Task<TReadDTO?> UpdateAsync(int id, TUpdateDTO request)
    {
        var data = await _repo.GetAsync(id);
        if (data is null)
        {
            throw new Exception("Id not found.");
        }
        var result = await _repo.UpdateAsync(id, _mapper.Map<TUpdateDTO, TModel>(request));
        return _mapper.Map<TModel, TReadDTO>(result);
    }
}