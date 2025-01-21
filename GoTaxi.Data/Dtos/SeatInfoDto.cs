namespace GoTaxi.Data.Dtos;
public class SeatInfoDto
{
    public Guid Id { get; set; }
    public string SeatName { get; set; }
    public decimal Discount { get; set; }

    public CarDto? Car { get; set; }
    public Guid CarId { get; set; }
}
