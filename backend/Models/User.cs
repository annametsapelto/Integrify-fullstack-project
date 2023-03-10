namespace Models;

public class User : BaseModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public Address? Address { get; set; }
    public IList<Order>? Orders { get; set; }
    public Role Role { get; set; } = Role.Customer;
}

public enum Role
{
    Customer,
    Admin
}