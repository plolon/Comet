using Comet.Models;
using Comet.Persistence.IRepositories;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<Vehicle>> GetAllVehiclesWithFeatures()
        {
            return await dbContext.Vehicles.Include(x => x.Features).ToListAsync();
        }

        public async Task<Vehicle> GetVehicleWithFeatures(int id)
        {
            return await dbContext.Vehicles.Include(v => v.Features).SingleOrDefaultAsync(v => v.Id.Equals(id));
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
