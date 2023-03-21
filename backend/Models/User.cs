using Microsoft.AspNetCore.Identity;

namespace Models;

public class User : IdentityUser<int>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public byte[] Password { get; set; } = null!;
    public IList<Order>? Orders { get; set; }
    public UserRole Role { get; set; } = UserRole.Customer;

  public enum UserRole
{
    Customer,
    Admin
}


}