namespace Repositories;

using Models;

public interface IBaseRepository<TModel>
{
     Task<TModel?> CreateAsync(TModel model);
    Task<TModel?> GetAsync(int id);
    Task<TModel?> UpdateAsync(int id, TModel update);
    Task<bool> DeleteAsync(int id);
    Task<ICollection<TModel>> GetAllAsync(QueryOptions options);


}        
public class QueryOptions
    {
        public string Sort { get; set; } = string.Empty;
        public string Search { get; set; } = string.Empty;
        public SortBy SortBy { get; set; }
        public int Limit { get; set; } = 30;
        public int Skip { get; set; } = 0;
    }

    public enum SortBy
    {
        ASC,
        DESC
    }