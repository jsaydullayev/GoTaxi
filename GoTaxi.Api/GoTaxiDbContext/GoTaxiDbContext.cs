using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.Data.GoTaxiDbContext;
public class GoTaxiDbContext : DbContext
{
    public GoTaxiDbContext(DbContextOptions<GoTaxiDbContext> options) : base(options)
    { }
    public DbSet<CarInfo> CarInfos { get; set; }
    public DbSet<Cars> Cars { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Payments> Payments { get; set; }
    public DbSet<SeatInfo> SeatInfos { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserCarOrders> UserCarOrders { get; set; }
    public DbSet<UserCars> UserCars { get; set; }
}
