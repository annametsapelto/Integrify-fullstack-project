namespace DTOs;

using Models;

public class UserBaseDTO
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!; 
    public IList<Order>? Orders { get; set; }
}
public class UserReadDTO : UserBaseDTO
{
}

public class UserCreateDTO : UserBaseDTO
{
    public string Password { get; set; } = null!;
}

public class UserUpdateDTO : UserBaseDTO
{
    public string Password { get; set; } = null!;
}
