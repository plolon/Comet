using Comet.Models;
using System.Collections;

namespace Comet.Persistence.IRepositories
{
    public interface IVehicleRepository : IGenericRepository<Vehicle>
    {
        Task<IEnumerable<Vehicle>> GetAllVehiclesWithFeatures();
        Task<Vehicle> GetVehicleWithFeatures(int id);
    }
}
