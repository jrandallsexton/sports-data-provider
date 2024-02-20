using SportsData.Provider.Middleware;

namespace SportsData.Provider
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureHealthChecks(this IServiceCollection services)
        {
            services.AddHealthChecks()
                .AddCheck<HealthCheckApi>("sports-data-provider");
            return services;
        }
    }
}