namespace GoTaxi.Entities
{
    public class UserCars
    {
        public bool IsOwner { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Cars Cars { get; set; }
        public Guid CarId { get; set; }
    }
}
