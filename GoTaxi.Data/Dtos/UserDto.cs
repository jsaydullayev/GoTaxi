namespace GoTaxi.Data.Dtos;
public class UserDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string Username { get; set; }
    public string HashPassword { get; set; }
    public string? Description { get; set; }
    public string Role { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime CreateAt = DateTime.UtcNow;

}
