using Comet.Models;
using Comet.Persistence.IRepositories;

namespace Comet.Persistence.Repositories
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(CometDbContext dbContext) : base(dbContext)
        {
        }
    }
}
