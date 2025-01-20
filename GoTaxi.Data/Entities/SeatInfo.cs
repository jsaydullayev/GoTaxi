namespace GoTaxi.Entities
{
    public class SeatInfo
    {
        public Guid Id { get; set; }
        public string SeatName { get; set; }
        public decimal Discount { get; set; }

        public Car? Car { get; set; }
        public Guid CarId { get; set; }
    }
}
