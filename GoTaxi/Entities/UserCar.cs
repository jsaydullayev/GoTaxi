namespace GoTaxi.Entities
{
    public class UserCar
    {
        public Guid Id {  get; set; }
        public bool IsOwner { get; set; }
        public Guid UserId { get; set; }
        public Guid CarId { get; set; } 
    }
}
