using Comet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comet.Persistence.Configuration
{
    public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.HasData(new Feature
            {
                Id = 1,
                Name = "Feature1",
            });
            builder.HasData(new Feature
            {
                Id = 2,
                Name = "Feature2",
            });
            builder.HasData(new Feature
            {
                Id = 3,
                Name = "Feature3",
            });
        }
    }
}
