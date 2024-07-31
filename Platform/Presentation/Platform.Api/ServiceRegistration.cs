using BaseProject.Application.Repositories;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using BaseProject.Persistence.Contexts;
using BaseProject.Persistence.Repositories.WriteRepository.Definitions;
using Platform.Api.Services.Company;
using Platform.Application.Abstractions.Services.Definitions;
using Platform.Application.Repositories.ReadRepository.Definitions;
using Platform.Application.Repositories.WriteRepository.Definitions;
using Platform.Persistence.Repositories.ReadRepository.Definitions;
using Platform.Persistence.Repositories.WriteRepository.Definitions;
using Platform.Persistence.Services.Definitions;

namespace Platform.Api
{
    public static class ServiceRegistration
    {
        public static void AddPlatformApiServices(this IServiceCollection services)
        {
            // Add services to the container.
            services.AddScoped<IBaseProjectDbContext, BaseProjectDbContext>();
            services.AddScoped<BaseProject.Application.Repositories.WriteRepository.Definitions.ICompanyWriteRepository, BaseProject.Persistence.Repositories.WriteRepository.Definitions.CompanyWriteRepository>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IBranchWriteRepository, BranchWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddDbContext<BaseProjectDbContext>();
        }
    }
}
