namespace Services;

public interface ICrudService<TModel, TDto>
{
    Task<TModel?> CreateAsync(TDto request);
    Task<TModel?> GetAsync(int id);
    Task<TModel?> UpdateAsync(int id, TDto request);
    Task<bool> DeleteAsync(int id);
    // TODO: Do pagination
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