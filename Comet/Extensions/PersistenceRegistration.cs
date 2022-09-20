using Comet.Persistence;
using Comet.Persistence.IRepositories;
using Comet.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Comet.Extensions
{
    public static class PersistenceRegistration
    {
        public static IServiceCollection ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CometDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IMakeRepository, MakeRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();

            return services;
        }
    }
}
