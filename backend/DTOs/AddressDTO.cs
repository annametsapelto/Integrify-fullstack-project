namespace DTOs;

using Models;

public class AddressDTO : BaseDTO<Address>
{
    public string StreetAddress { get; set; } = null!;
    public string Zip { set; get; } = null!;
    public string City { get; set; } = null!;
    public string? Country { get; set; } = "Finland";
    public override void UpdateModel(Address model)
    {
        throw new NotImplementedException();
    }
}