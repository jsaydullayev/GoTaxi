namespace GoTaxi.Data.Exceptions;
public class NotFoundException : Exception
{
    public NotFoundException(string message): base(message) { }
}
