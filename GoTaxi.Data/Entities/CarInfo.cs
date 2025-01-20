﻿namespace GoTaxi.Entities
{
    public class CarInfo
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int SeatCounts { get; set; }
        public List<SeatInfo>? SeatInfos { get; set; }
        public Guid CarId { get; set; }
        public Car? Cars { get; set; }
    }
}