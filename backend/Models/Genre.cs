namespace Models;

public class Genre : BaseModel
{
    public string GenreName { get; set; } = null!;
    public string? Description { get; set; }
}