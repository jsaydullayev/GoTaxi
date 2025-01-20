namespace GoTaxi.Entities;
public class Car
{
    public Guid Id { get; set; }
    public string Model { get; set; }
    public string CarName { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; }
    public List<CarInfo>? CarInfos { get; set; }
    public List<UserCars>? UserCars { get; set; } 
    
    public User? User { get; set; }
    public Guid UserId { get; set; }
    public Destination? Destination { get; set; }
    public Guid DestinationId { get; set; }
}
