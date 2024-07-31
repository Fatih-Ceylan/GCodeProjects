using GCard.Application.Abstractions.Services.Payment;
using GCard.Infrastructure.Services.Payment;
using Microsoft.Extensions.DependencyInjection;

namespace GCard.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddGCardInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IVakifBankVposService, VakifBankVposService>(); 
            services.AddScoped<IVakifBank3dSecureService, VakifBank3dSecureService>();
            services.AddHttpClient<IVakifBank3dSecureService, VakifBank3dSecureService>();
        }
    }
}
