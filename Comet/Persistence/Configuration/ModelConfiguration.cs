using Comet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comet.Persistence.Configuration
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(new Model
            {
                Id = 1,
                Name = "Make1-ModelA",
                MakeId = 1,
            }); builder.HasData(new Model
            {
                Id = 2,
                Name = "Make1-ModelB",
                MakeId = 1,
            }); builder.HasData(new Model
            {
                Id = 3,
                Name = "Make1-ModelC",
                MakeId = 1,
            });
            builder.HasData(new Model
            {
                Id = 4,
                Name = "Make2-ModelA",
                MakeId = 2,
            }); builder.HasData(new Model
            {
                Id = 5,
                Name = "Make2-ModelB",
                MakeId = 2,
            }); builder.HasData(new Model
            {
                Id = 6,
                Name = "Make2-ModelC",
                MakeId = 2,
            });
            builder.HasData(new Model
            {
                Id = 7,
                Name = "Make3-ModelA",
                MakeId = 3,
            }); builder.HasData(new Model
            {
                Id = 8,
                Name = "Make3-ModelB",
                MakeId = 3,
            }); builder.HasData(new Model
            {
                Id = 9,
                Name = "Make3-ModelC",
                MakeId = 3,
            });
        }
    }
}
