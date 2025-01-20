using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.Data.GoTaxiDbContext;
public class TaxiDbContext : DbContext
{
    public TaxiDbContext(DbContextOptions<TaxiDbContext> options) : base(options)
    { }
    public DbSet<CarInfo> CarInfos { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<SeatInfo> SeatInfos { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserCarOrders> UserCarOrders { get; set; }
    public DbSet<UserCars> UserCars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .HasOne(c => c.Destination)
            .WithOne(d => d.Cars)
            .HasForeignKey<Destination>(d => d.CarId); // CarId - свойство, используемое в качестве внешнего ключа

        base.OnModelCreating(modelBuilder);
    }

}
