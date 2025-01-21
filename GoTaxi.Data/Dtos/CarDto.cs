namespace GoTaxi.Data.Dtos;
public class CarDto
{
    public Guid Id { get; set; }
    public string Model { get; set; }
    public string CarName { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; }
    public UserDto? User { get; set; }
    public Guid UserId { get; set; }
    public Guid DestinationId { get; set; }
}
