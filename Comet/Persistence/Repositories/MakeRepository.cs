using Comet.Models;
using Comet.Persistence.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Comet.Persistence.Repositories
{
    public class MakeRepository : GenericRepository<Make>, IMakeRepository
    {
        private readonly CometDbContext dbContext;

        public MakeRepository(CometDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable> GetAllMakesWithModels()
        {
            return await dbContext.Makes.Include(x => x.Models).ToListAsync();
        }

        public async Task<Make> GetMakeWithModels(int id)
        {
            return await dbContext.Makes.Include(x => x.Models).FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
