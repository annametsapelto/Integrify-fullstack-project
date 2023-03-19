namespace Models;

public class User : BaseModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public byte[] Password { get; set; } = null!;
    public byte[] Salt { get; set; } = null!;
    public IList<Order>? Orders { get; set; }
    public UserRole Role { get; set; } = UserRole.Customer;

  public enum UserRole
{
    Customer,
    Admin
}


}