using GHR.Infrastructure.ElasticSearch.Interface;
using GHR.Infrastructure.ElasticSearch.Services;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace GHR.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddGHRInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IElasticSearchService, ElasticSearchService>();
            services.AddSingleton<IElasticClient, ElasticClient>();
        }
    }
}
