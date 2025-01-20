﻿namespace GoTaxi.Entities;
public class UserCarOrders
{
    public int Id { get; set; }
    public string FromLocation { get; set; }
    public string ToLocation { get; set; }
    public string? Price { get; set; }
    public string? Place { get; set; }
    public string? Description { get; set; }

    public User? User { get; set; }
    public Guid UserId { get; set; }

    public Car? Car { get; set; }
    public Guid CarId { get; set; }

    public Payment? Payments { get; set; }
    public int PaymentId { get; set; }

}
