using Comet.Models;
using Comet.Persistence.IRepositories;

namespace Comet.Persistence.Repositories
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        private readonly CometDbContext dbContext;

        public VehicleRepository(CometDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public override async Task<Vehicle> Add(Vehicle entity)
        {
            await dbContext.Vehicles.AddAsync(entity);
            entity.LastUpdate = DateTime.Now;
            await dbContext.SaveChangesAsync();
            return entity;
        }
        public override async Task<Vehicle> Update(Vehicle entity)
        {
            dbContext.Vehicles.Update(entity);
            entity.LastUpdate = DateTime.Now;
            await dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
