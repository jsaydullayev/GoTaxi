namespace GoTaxi.Data.Exceptions;
public class ForBadRequestException : BadRequestException
{
    ForBadRequestException()
        : base("Some issue happened, please try again") { }
}
