using Comet.Models;
using Comet.Persistence.IRepositories;

namespace Comet.Persistence.Repositories
{
    public class FeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        public FeatureRepository(CometDbContext dbContext) : base(dbContext)
        {
        }
    }
}
