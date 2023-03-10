namespace DTOs;

using Models;

public class UserDTO : BaseDTO<User>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public Address? Address { get; set; }
    public IList<Order>? Orders { get; set; }
    public Role Role { get; set; } = Role.Customer;

    public override void UpdateModel(User model)
    {
        throw new NotImplementedException();
    }
}