//using GControl.Application.Repositories;
//using BaseProject.Domain.Entities.GControl.Definitions;
//using BaseProject.Domain.Entities.GControl.Definitions.Files;
//using Microsoft.AspNetCore.Http;

////using BaseProject.Domain.Entities.GControl.Definitions.Files;
//using Microsoft.EntityFrameworkCore;
//using System.Security.Claims;
//using Utilities.Core.UtilityDomain.Entities;
//using Utilities.Core.UtilityDomain.Entities.Files;

//namespace GControl.Persistence.Contexts
//{
//    public class BaseProjectDbContext : DbContext, IBaseProjectDbContext
//    {
//        readonly IHttpContextAccessor _httpContextAccessor;

//        public BaseProjectDbContext(DbContextOptions<BaseProjectDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
//        {
//            _httpContextAccessor = httpContextAccessor;
//        }

//        private string GetConnectionString(string? dbName)
//        {
//            return $"Server={Configuration.GControlConnectionString.Select(t => t.server).FirstOrDefault()};" +
//                   $" Database={dbName?.ToLower() ?? Configuration.GControlConnectionString.Select(t => t.database).FirstOrDefault()}_gcontrol; " +
//                   $"User Id={Configuration.GControlConnectionString.Select(t => t.userId).FirstOrDefault()};" +
//                   $" Password={Configuration.GControlConnectionString.Select(t => t.password).FirstOrDefault()}; " +
//                   $"TrustServerCertificate=True";

//            //return "Server=10.0.0.55; Database=gcode_gcontrol; User Id=sa; Password=Green1453; TrustServerCertificate=True";
//            //return $"Server=10.0.0.55; Database={dbName}_gcrm; User Id=sa; Password=Green1453; TrustServerCertificate=True";
//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(GetConnectionString(_httpContextAccessor?.HttpContext?.Request?.Headers?["Route-Name"]));

//            //optionsBuilder.UseSqlServer(GetConnectionString(null));
//        }



//        public void GControlUpdateDatabase(string dbName)
//        {
//            Database.GetDbConnection().ConnectionString = GetConnectionString(dbName);
//            var migrations = Database.GetPendingMigrations();

//            if (migrations.Any())
//            {
//                Database.Migrate();
//            }
//        }

//        public async Task<string> GetCurrentUserNameAsync()
//        {
//            return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
//        }

//        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
//        {
//            #region Tüm entitylerde ortak değişiklikler
//            //ChangeTracker entitiy üzerinde yapılan değişiklikleri yakalar.

//            var datas = ChangeTracker.Entries<BaseEntity>(); //tip base entitiy olarak giren tüm modelleri yakala

//            foreach (var data in datas)
//            {
//                switch (data.State)
//                {
//                    case EntityState.Detached:
//                        break;
//                    case EntityState.Unchanged:
//                        break;
//                    case EntityState.Deleted:
//                        break;
//                    case EntityState.Modified:
//                        if (data.Entity.IsDeleted)
//                        {
//                            data.Entity.DeletedBy = await GetCurrentUserNameAsync();
//                            data.Entity.DeletedDate = DateTime.Now;
//                        }
//                        else
//                        {
//                            data.Entity.UpdatedBy = await GetCurrentUserNameAsync();
//                            data.Entity.UpdatedDate = DateTime.Now;
//                        }
//                        break;
//                    case EntityState.Added:
//                        data.Entity.CreatedBy = await GetCurrentUserNameAsync() ?? "user none";
//                        data.Entity.CreatedDate = DateTime.Now;
//                        break;
//                    default:
//                        break;
//                }
//            }
//            #endregion

//            return await base.SaveChangesAsync(cancellationToken);
//        }
//    }
//}