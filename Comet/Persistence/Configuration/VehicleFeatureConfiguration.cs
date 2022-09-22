using Comet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comet.Persistence.Configuration
{
    public class VehicleFeatureConfiguration : IEntityTypeConfiguration<VehicleFeature>
    {
        public void Configure(EntityTypeBuilder<VehicleFeature> builder)
        {
            builder.HasKey(vf => new { vf.VehicleId, vf.FeatureId });
        }
    }
}
