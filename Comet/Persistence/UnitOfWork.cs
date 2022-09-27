namespace Comet.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CometDbContext dbContext;

        public UnitOfWork(CometDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Complete()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
