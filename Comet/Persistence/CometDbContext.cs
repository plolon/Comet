using Comet.Models;
using Microsoft.EntityFrameworkCore;

namespace Comet.Persistence
{
    public class CometDbContext :DbContext
    {
        public CometDbContext(DbContextOptions<CometDbContext> options) : base(options) { }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleFeature> VehicleFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CometDbContext).Assembly);
        }
    }
}
