namespace Services;

using Repositories;

public interface ICrudService<TModel, TCreateDTO, TReadDTO, TUpdateDTO>
{
    Task<TReadDTO?> CreateAsync(TCreateDTO request);
    Task<TReadDTO?> GetAsync(int id);
    Task<TReadDTO?> UpdateAsync(int id, TUpdateDTO request);
    Task<bool> DeleteAsync(int id);
    Task<ICollection<TReadDTO>> GetAllAsync(QueryOptions options);
}        
