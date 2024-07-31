using GHR.Application.Models;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace GHR.Application
{
    public static class ServiceRegistration
    {
        public static void AddGHRApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
