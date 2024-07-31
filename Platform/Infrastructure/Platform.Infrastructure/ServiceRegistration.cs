using Microsoft.Extensions.DependencyInjection;
using Platform.Application.Abstractions.Services;
using Platform.Application.Abstractions.Token;
using Platform.Infrastructure.Services;
using Platform.Infrastructure.Services.Token;

namespace Platform.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddPlatformInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IBaseProjectService, BaseProjectService>();
            services.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
