namespace Comet.Persistence
{
    public interface IUnitOfWork
    {
        Task Complete();
    }
}
