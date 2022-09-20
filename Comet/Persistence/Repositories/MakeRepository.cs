using Comet.Models;
using Comet.Persistence.IRepositories;

namespace Comet.Persistence.Repositories
{
    public class MakeRepository : GenericRepository<Make>, IMakeRepository
    {
        public MakeRepository(CometDbContext dbContext) : base(dbContext)
        {
        }
    }
}
