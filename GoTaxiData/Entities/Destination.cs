namespace GoTaxi.Entities
{
    public class Destination
    {
        public Guid Id { get; set; }
        public string FromWhere { get; set; }
        public string ToWhere { get; set; }
        public Guid CarId { get; set; }
    }
}
