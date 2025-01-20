namespace GoTaxi.Entities
{
    public class UserCars
    {
        public Guid Id { get; set; }
        public bool IsOwner { get; set; }
        public string OwnerName { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid CarId { get; set; }
        public Car? Cars { get; set; }
    }
}
 