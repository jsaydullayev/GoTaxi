namespace GoTaxi.Data.Dtos;

public class CarInfoDto
{
    public Guid Id { get; set; }
    public string Text { get; set; }
    public int SeatCounts { get; set; }
    public Guid CarId { get; set; }
    public CarDto? Cars { get; set; }
}
