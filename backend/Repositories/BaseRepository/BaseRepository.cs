namespace Repositories;

using Database;
using Microsoft.EntityFrameworkCore;
using Models;

public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : BaseModel
{
    protected readonly AppDbContext _dbContext;
    public BaseRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TModel?> CreateAsync(TModel model)
    {
        await _dbContext.Set<TModel>().AddAsync(model);
        await _dbContext.SaveChangesAsync();
        return model;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await GetAsync(id);
        if(entity is null)
        {
            return false;
        }else
        {
            _dbContext.Set<TModel>().Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }

    public async Task<ICollection<TModel>> GetAllAsync(QueryOptions options)
    {
        var query = _dbContext.Set<TModel>().AsNoTracking();
        if (options.Sort.Trim().Length > 0)
        {
            if (query.GetType().GetProperty(options.Sort) != null) 
            {
                query.OrderBy(e => e.GetType().GetProperty(options.Sort));
            } 
            query.Take(options.Limit).Skip(options.Skip);
            }
        return await query.ToArrayAsync();
    }

    public async Task<TModel?> GetAsync(int id)
    {
        return await _dbContext.Set<TModel>().FindAsync(id);
    }

    public async Task<TModel?> UpdateAsync(int id, TModel update)
    {
        var entity = update;
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    
}