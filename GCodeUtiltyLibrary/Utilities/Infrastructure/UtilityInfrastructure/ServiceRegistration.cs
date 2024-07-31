using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
using StackExchange.Redis;
using Utilities.Core.UtilityApplication.Abstractions.CurrentUser;
using Utilities.Core.UtilityApplication.Abstractions.Excel;
using Utilities.Core.UtilityApplication.Abstractions.Mail;
using Utilities.Core.UtilityApplication.Abstractions.Sha256;
using Utilities.Core.UtilityApplication.Abstractions.Storage;
using Utilities.Infrastructure.UtilityInfrastructure.Enums;
using Utilities.Infrastructure.UtilityInfrastructure.Services.CurrentUser;
using Utilities.Infrastructure.UtilityInfrastructure.Services.Excel;
using Utilities.Infrastructure.UtilityInfrastructure.Services.Mail;
using Utilities.Infrastructure.UtilityInfrastructure.Services.RedisCache.InterFaces;
using Utilities.Infrastructure.UtilityInfrastructure.Services.RedisCache.Services;
using Utilities.Infrastructure.UtilityInfrastructure.Services.Sha256;
using Utilities.Infrastructure.UtilityInfrastructure.Services.Storage;
using Utilities.Infrastructure.UtilityInfrastructure.Services.Storage.Local;

namespace Utilities.Infrastructure.UtilityInfrastructure
{
    public static class ServiceRegistration
    {
        public static void AddUtilityInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ISha256Service, Sha256Service>();
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
        }

        public static void AddStroage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<IExcelService, ExcelService>();
            serviceCollection.AddScoped<IStorage, T>();
        }

        public static void AddStroage(this IServiceCollection serviceCollection, StorageTypeEnum storageType)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();

            switch (storageType)
            {
                case StorageTypeEnum.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageTypeEnum.Azure:
                    //serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
        public static void AddRedisCache(this IServiceCollection services, IConfiguration configuration)
        {
            var multiplexer = ConnectionMultiplexer.Connect(configuration.GetConnectionString("Redis"));
            
            services.AddSingleton<IConnectionMultiplexer>(multiplexer);
            services.AddSingleton<IRedisCacheService, RedisCacheService>();
        }
    }
}