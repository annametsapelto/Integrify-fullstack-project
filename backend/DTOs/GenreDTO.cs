namespace DTOs;

using Models;

public class GenreDTO : BaseDTO<Genre>
{
    public string GenreName { get; set; } = null!;
    public string? Description { get; set; }

    public override void UpdateModel(Genre model)
    {
        throw new NotImplementedException();
    }
}