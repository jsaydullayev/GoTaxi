namespace GoTaxi.Data.Dtos;
public class UserCarOrdersDto
{
    public int Id { get; set; }
    public string FromLocation { get; set; }
    public string ToLocation { get; set; }
    public string? Price { get; set; }
    public string? Place { get; set; }
    public string? Description { get; set; }

    public UserDto? User { get; set; }  
    public Guid UserId { get; set; }

    public CarDto? Car { get; set; }
    public Guid CarId { get; set; }
}
