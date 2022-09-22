using Comet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comet.Persistence.Configuration
{
    public class MakeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(new Make
            {
                Id = 1,
                Name = "Make1",
            });
            builder.HasData(new Make
            {
                Id = 2,
                Name = "Make2",
            });
            builder.HasData(new Make
            {
                Id = 3,
                Name = "Make3",
            });
        }
    }
}
