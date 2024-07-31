using GCard.Application.Models;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using P = Platform.Application.Models;

namespace GCard.Application
{
    public static class ServiceRegistration
    {
        public static void AddGCardApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceRegistration));
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddAutoMapper(typeof(P.MappingProfile));
        }
    }
}
