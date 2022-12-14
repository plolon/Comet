using Comet.Models;
using System.Collections;

namespace Comet.Persistence.IRepositories
{
    public interface IMakeRepository : IGenericRepository<Make>
    {
        Task<IEnumerable> GetAllMakesWithModels();
        Task<Make> GetMakeWithModels(int id);
    }
}
