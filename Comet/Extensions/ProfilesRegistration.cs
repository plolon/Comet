using Comet.Profiles;

namespace Comet.Extensions
{
    public static class ProfilesRegistration
    {
        public static IServiceCollection ConfigureProfiles(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
