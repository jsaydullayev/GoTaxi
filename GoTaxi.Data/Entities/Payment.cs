namespace GoTaxi.Entities;
public class Payment
{
    public int Id { get; set; }
    public string Amount { get; set; }

    public DateTime PaymentDate = DateTime.UtcNow;
    public string Status { get; set; }
    public string PaymentMethod { get; set; }

    public User? User { get; set; }
    public Guid OrderId { get; set; }
}
