using Comet.Models;
using Comet.Persistence.IRepositories;

namespace Comet.Persistence.Repositories
{
    public class ModelRepository : GenericRepository<Model>, IModelRepository
    {
        public ModelRepository(CometDbContext dbContext) : base(dbContext)
        {
        }
    }
}
