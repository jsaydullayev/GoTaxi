namespace GoTaxi.Data.Exceptions;
public class CarNotFoundException : NotFoundException
{
    public  CarNotFoundException(Guid carId)
        : base($"Car with id: {carId} not found.") 
    { }
}
