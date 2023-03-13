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
    public User.UserRole Role { get; set; }

    public override void UpdateModel(User model)
    {
        model.FirstName = FirstName;
        model.LastName = LastName;
        model.Email = Email;
        model.Password = Password;
        model.Address = Address;
        model.Orders = Orders;
        model.Role = Role;
    }
}