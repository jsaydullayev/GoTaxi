namespace GoTaxi.Entities;
public class Cars
{
    public Guid Id { get; set; }
    public string Model { get; set; }
    public string CarName { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; }
    public List<CarInfo> CarInfos { get; set; }
    public List<UserCar> UserCars { get; set; } = new();
    
    public User? User { get; set; }
    public Destination Destination { get; set; }
    public Guid DestinationId { get; set; }
}
