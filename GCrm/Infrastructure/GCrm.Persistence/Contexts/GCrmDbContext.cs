using GCrm.Application.Repositories;
using GCrm.Domain.Entities.ActivityManagement;
using GCrm.Domain.Entities.ActivityManagement.Files;
using GCrm.Domain.Entities.CustomerManagement;
using GCrm.Domain.Entities.CustomerManagement.Files;
using GCrm.Domain.Entities.Definitions;
using GCrm.Domain.Entities.Definitions.Activities;
using GCrm.Domain.Entities.Definitions.Customers;
using GCrm.Domain.Entities.UserManagement;
using Microsoft.EntityFrameworkCore;
using Utilities.Core.UtilityDomain.Entities;
using Utilities.Core.UtilityDomain.Entities.Files;

namespace GCrm.Persistence.Contexts
{
    public class GCrmDbContext : DbContext, IGCrmDbContext
    {
        //readonly IHttpContextAccessor _httpContextAccessor;

        //public GCrmDbContext(DbContextOptions<GCrmDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //}

        private string GetConnectionString(string? dbName)
        {
            return $"Server={Configuration.GCrmConnectionString.Select(t => t.server).FirstOrDefault()};" +
                   $" Database={dbName?.ToLower() ?? Configuration.GCrmConnectionString.Select(t => t.database).FirstOrDefault()}_gcrm; " +
                   $"User Id={Configuration.GCrmConnectionString.Select(t => t.userId).FirstOrDefault()};" +
                   $" Password={Configuration.GCrmConnectionString.Select(t => t.password).FirstOrDefault()}; " +
                   $"TrustServerCertificate=True";

            //return "Server=10.0.0.55; Database=gcode_gcrm2; User Id=sa; Password=Green1453; TrustServerCertificate=True";
            //return $"Server=10.0.0.55; Database={dbName}_gcrm; User Id=sa; Password=Green1453; TrustServerCertificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(GetConnectionString(_httpContextAccessor?.HttpContext?.Request?.Headers?["Route-Name"]));

            optionsBuilder.UseSqlServer(GetConnectionString(null));
        }

        #region Definitions

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        //public DbSet<Currency> Currencies { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerActivity>  CustomerActivities  { get; set; }

        public DbSet<CustomerActivityKind> CustomerActivityKinds { get; set; }
        public DbSet<CustomerActivityStatus> CustomerActivityStatuses { get; set; }
        public DbSet<CustomerActivityType> CustomerActivityTypes { get; set; }

        //public DbSet<CustomerOffer> CustomerOffers { get; set; }
        //public DbSet<CustomerProject> CustomerProjects { get; set; }

        //public DbSet<CustomerSubject> CustomerSubjects { get; set; }

        public DbSet<CustomerAddress> CustomerAddresses { get; set; }

        public DbSet<CustomerCategory> CustomerCategories { get; set; }

        public DbSet<CustomerContact> CustomerContacts { get; set; }

        public DbSet<CustomerKind> CustomerKinds { get; set; }

        public DbSet<CustomerSector> CustomerSectors { get; set; }

        public DbSet<CustomerSource> CustomerSources { get; set; }

        public DbSet<CustomerStatus> CustomerStatuses { get; set; }

        public DbSet<CustomerType> CustomerTypes { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Users>  Users { get; set; }



        #region Files

        public DbSet<AppFile> AppFiles { get; set; }

        public DbSet<CustomerActivityFile> CustomerActivityFiles { get; set; }

        public DbSet<CustomerContactFile> CustomerContactFiles { get; set; }

        public DbSet<CustomerFile> CustomerFiles { get; set; }

        public DbSet<CustomerRepresentative>  CustomerRepresentatives { get; set; }

        #endregion

        #endregion

        public void GCrmUpdateDatabase(string dbName)
        {
            Database.GetDbConnection().ConnectionString = GetConnectionString(dbName);
            var migrations = Database.GetPendingMigrations();

            if (migrations.Any())
            {
                Database.Migrate();
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            #region Tüm entitylerde ortak değişiklikler
            //ChangeTracker entitiy üzerinde yapılan değişiklikleri yakalar.

            var datas = ChangeTracker.Entries<BaseEntity>(); //tip base entitiy olarak giren tüm modelleri yakala

            foreach (var data in datas)
            {
                //TODO Id added anında verilecek.
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };
            }
            #endregion

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}