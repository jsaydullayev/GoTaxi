using GoTaxi.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoTaxi.GoTaxiDbContext
{
    public class TaxiDbContext : DbContext
    {
        public TaxiDbContext(DbContextOptions<TaxiDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<UserCarOrders> Orders { get; set; }
        public DbSet<Payments> Payments { get; set; }
    }
}
