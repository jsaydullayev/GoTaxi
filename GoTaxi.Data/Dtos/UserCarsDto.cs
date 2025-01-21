namespace GoTaxi.Data.Dtos;
public class UserCarsDto
{
    public Guid Id { get; set; }
    public bool IsOwner { get; set; }
    public string OwnerName { get; set; }

    public Guid UserId { get; set; }
    public UserDto? User { get; set; }

    public Guid CarId { get; set; }
    public CarDto? Cars { get; set; }
}
