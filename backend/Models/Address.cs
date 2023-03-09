namespace Models;

public class Address : BaseModel
{
    public string StreetAddress { get; set; } = null!;
    public string Zip { set; get; } = null!;
    public string City { get; set; } = null!;
    public string? Country { get; set; } = "Finland";
}