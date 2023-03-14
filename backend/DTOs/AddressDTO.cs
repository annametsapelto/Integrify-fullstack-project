namespace DTOs;

using Models;
using System.ComponentModel.DataAnnotations;

public class AddressDTO : BaseDTO<Address> 
{
    [MinLength(5)]
    public string StreetAddress { get; set; } = null!;
    [MinLength(5), MaxLength(5)]
    public string Zip { set; get; } = null!;
    [MinLength(2)]
    public string City { get; set; } = null!;
    public string? Country { get; set; } = "Finland";
    public override void UpdateModel(Address model)
    {
        model.StreetAddress = StreetAddress;
        model.Zip = Zip;
        model.City = City;
        model.Country = Country;
    }
}