using Comet.Models;
using Microsoft.EntityFrameworkCore;

namespace Comet.Persistence
{
    public class CometDbContext :DbContext
    {
        public CometDbContext(DbContextOptions<CometDbContext> options) : base(options) { }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
