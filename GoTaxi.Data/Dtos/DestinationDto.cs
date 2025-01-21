namespace GoTaxi.Data.Dtos;
public class DestinationDto
{

    public Guid Id { get; set; }
    public string FromWhere { get; set; }
    public string ToWhere { get; set; }
    public Guid CarId { get; set; }
    public CarDto? Cars { get; set; }
}
