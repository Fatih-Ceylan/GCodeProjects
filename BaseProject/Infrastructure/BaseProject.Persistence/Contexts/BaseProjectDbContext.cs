using BaseProject.Application.Repositories;
using BaseProject.Domain.Entities;
using BaseProject.Domain.Entities.Definitions;
using BaseProject.Domain.Entities.Definitions.Files;
using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Domain.Entities.GControl.Definitions;
using BaseProject.Domain.Entities.GCrm.Definitions.ActivitiesManagement.Activities;
using BaseProject.Domain.Entities.GCrm.Definitions.ActivitiesManagement.Activities.Files;
using BaseProject.Domain.Entities.GCrm.Definitions.CustomerManagement.Contacts;
using BaseProject.Domain.Entities.GCrm.Definitions.CustomerManagement.Customers;
using BaseProject.Domain.Entities.GCrm.Definitions.CustomerManagement.Customers.Files;
using BaseProject.Domain.Entities.GCrm.Definitions.OpportunityManagement.Opportunity;
using BaseProject.Domain.Entities.GCrm.Definitions.ProductManagement.Products;
using BaseProject.Domain.Entities.GCrm.Definitions.ProjectManagement.Projects;
using BaseProject.Domain.Entities.GCrm.Definitions.UserManagement.Users;
using BaseProject.Domain.Entities.GHR.Employment;
using BaseProject.Domain.Entities.GHR.Files;
using BaseProject.Domain.Entities.GHR.Recruitment.Applications;
using BaseProject.Domain.Entities.GHR.Recruitment.Jobs;
using BaseProject.Domain.Entities.GHR.Recruitment.Recruit;
using BaseProject.Domain.Entities.Identity;
using BaseProject.Domain.Entities.NLLogistics.Definitions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Security.Claims;
using Utilities.Core.UtilityDomain.Entities;
using Utilities.Core.UtilityDomain.Entities.Files;

namespace BaseProject.Persistence.Contexts
{
    public class BaseProjectDbContext : IdentityDbContext<AppUser, AppRole, string>, IBaseProjectDbContext
    {
        readonly IHttpContextAccessor _httpContextAccessor;

        public BaseProjectDbContext(
            DbContextOptions<BaseProjectDbContext> options,
            IHttpContextAccessor httpContextAccessor) : base(options)
        { _httpContextAccessor = httpContextAccessor; }

        private string GetConnectionString(string? dbName)
        {
            return $"Server={Configuration.BaseProjectConnectionString.Select(t => t.server).FirstOrDefault()};" +
                $" Database={dbName?.ToLower() ?? Configuration.BaseProjectConnectionString.Select(t => t.database).FirstOrDefault()}_base; " +
                $"User Id={Configuration.BaseProjectConnectionString.Select(t => t.userId).FirstOrDefault()};" +
                $" Password={Configuration.BaseProjectConnectionString.Select(t => t.password).FirstOrDefault()}; " +
                $"TrustServerCertificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString(_httpContextAccessor?.HttpContext?.Request?.Headers?["Route-Name"]));
        }

        public async Task<string> GetCurrentUserNameIdentifierAsync()
        {
            return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "9f5cb7c6-8a69-4eaf-9898-a5d9e2ed699f";  //şimdilik bu şekilde mevcut data verildi.
        }

        //TODO temiz db de başına base koyulacak
        #region BaseProject

        #region Definitions
        public DbSet<Company> Companies { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Domain.Entities.Definitions.Department> Departments { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<MailCredantial> MailCredantials { get; set; }

        public DbSet<CompanyLicense> CompanyLicenses { get; set; }

        public DbSet<AppUserLicense> AppUserLicenses { get; set; }

        public DbSet<AddressType> AddressTypes { get; set; }

        public DbSet<CompanyAddress> CompanyAddresses { get; set; }


        #region Files
        public DbSet<AppFile> AppFiles { get; set; }

        public DbSet<CompanyFile> CompanyFiles { get; set; }
        #endregion

        #endregion

        #endregion

        #region GHR

        #region Recruitment

        public DbSet<JobApplicant> GHR_JobApplicants { get; set; }

        public DbSet<JobApplication> GHR_JobApplications { get; set; }

        public DbSet<JobApplicationStatus> GHR_JobApplicationStatuses { get; set; }

        public DbSet<JobApplicationStatusHistory> GHR_JobApplicationStatusHistories { get; set; }

        public DbSet<JobApplicantDocument> GHR_JobApplicantDocuments { get; set; }

        public DbSet<JobAdvert> GHR_JobAdverts { get; set; }

        public DbSet<JobAdvertPostedOn> GHR_JobAdvertPostedOn { get; set; }

        public DbSet<Notes> GHR_Notes { get; set; }

        public DbSet<Recruiter> GHR_Recruiters { get; set; }

        public DbSet<RecruitmentProcess> GHR_RecruitmentProcesses { get; set; }

        public DbSet<RecruitmentStep> GHR_RecruitmentSteps { get; set; }

        public DbSet<RecruitmentProcessStep> GHR_RecruitmentProcessSteps { get; set; }

        #endregion

        public DbSet<Domain.Entities.GHR.Employment.Employee> GHR_Employees { get; set; }

        public DbSet<EmployeeRoles> GHR_EmployeeRoles { get; set; }

        public DbSet<EducationInfo> GHR_EducationInfos { get; set; }

        public DbSet<JobHistory> GHR_JobHistories { get; set; }

        public DbSet<DepartmentManager> GHR_DepartmentManagers { get; set; }

        public DbSet<Appellation> GHR_Appellations { get; set; }

        public DbSet<Leave> GHR_Leaves { get; set; }

        public DbSet<LeaveType> GHR_LeaveTypes { get; set; }

        public DbSet<Payroll> GHR_Payrolls { get; set; }

        public DbSet<Domain.Entities.GHR.Employment.Location> GHR_Locations { get; set; }

        public DbSet<RoleType> GHR_RoleTypes { get; set; }

        public DbSet<SelfService> GHR_SelfServices { get; set; }

        #endregion

        #region GControl
        #region Definitions

        public DbSet<ApplicationSetting> GControl_ApplicationSettings { get; set; }
        public DbSet<Domain.Entities.GControl.Definitions.Employee> GControl_Employees { get; set; }
        public DbSet<EmployeeLabel> GControl_EmployeeLabels { get; set; }
        public DbSet<EmployeeType> GControl_EmployeeTypes { get; set; }
        public DbSet<EntryExitManagement> GControl_EntryExitManagements { get; set; }
        public DbSet<Domain.Entities.GControl.Definitions.Location> GControl_Locations { get; set; }
        public DbSet<UserMainInfo> GControl_UserMainInfo { get; set; }
        public DbSet<ShiftManagement> GControl_ShiftManagements { get; set; }
        public DbSet<Domain.Entities.GControl.Definitions.PasswordRemake> GControl_PasswordRemakes { get; set; }
        public DbSet<Announcement> GControl_Announcement { get; set; }
        public DbSet<Domain.Entities.GControl.Definitions.Department> GControl_Department { get; set; }


        #region Files

        public DbSet<Domain.Entities.GControl.Definitions.Files.EmployeeFile> GControl_EmployeeFiles { get; set; }

        #endregion

        #endregion
        #endregion

        #region GCard 

        #region Definitions

        public DbSet<Staff> GCard_Staffs { get; set; }
        public DbSet<Iban> GCard_Ibans { get; set; }
        public DbSet<PhoneNumber> GCard_PhoneNumbers { get; set; }
        public DbSet<SocialMedia> GCard_SocialMedias { get; set; }
        public DbSet<SocialMediaUrl> GCard_SocialMediaUrls { get; set; }
        public DbSet<StaffContact> GCard_StaffContacts { get; set; }
        public DbSet<Domain.Entities.GCard.Definitions.PasswordRemake> GCard_PasswordRemakes { get; set; }
        public DbSet<StaffField> GCard_StaffFields { get; set; }
        public DbSet<Field> GCard_Fields { get; set; }
        //public DbSet<AppFile> GCard_AppFiles { get; set; }
        public DbSet<Card> GCard_Cards { get; set; }
        public DbSet<Cargo> GCard_Cargos { get; set; }
        public DbSet<Order> GCard_Orders { get; set; }
        public DbSet<OrderDetail> GCard_OrderDetails { get; set; }
        public DbSet<Address> GCard_Addresses { get; set; }
        public DbSet<Invoice> GCard_Invoices { get; set; }

        #endregion

        #endregion

        #region GCrm
        #region Definitions

     
        public DbSet<Customer> GCrm_Customers { get; set; }
        public DbSet<CustomerGroup> GCrm_CustomerGroups { get; set; }
        public DbSet<CustomerActivity> GCrm_CustomerActivities { get; set; }
        public DbSet<CustomerActivitySubject> GCrm_CustomerActivitySubjects { get; set; }
        public DbSet<CustomerActivityKind> GCrm_CustomerActivityKinds { get; set; }
        public DbSet<CustomerActivityTeam> GCrm_CustomerActivityTeams { get; set; }
        public DbSet<CustomerActivityStatus> GCrm_CustomerActivityStatuses { get; set; }
        public DbSet<CustomerActivityType> GCrm_CustomerActivityTypes { get; set; }
        public DbSet<CustomerAddress> GCrm_CustomerAddresses { get; set; }
        public DbSet<CustomerCategory> GCrm_CustomerCategories { get; set; }
        public DbSet<CustomerContact> GCrm_CustomerContacts { get; set; }
        public DbSet<CustomerKind> GCrm_CustomerKinds { get; set; }
        public DbSet<CustomerSector> GCrm_CustomerSectors { get; set; }
        public DbSet<CustomerSource> GCrm_CustomerSources { get; set; }
        public DbSet<CustomerStatus> GCrm_CustomerStatuses { get; set; }
        public DbSet<CustomerType> GCrm_CustomerTypes { get; set; }
        //public DbSet<CustomerRepresentative> GCrm_CustomerRepresentatives { get; set; }
        public DbSet<Users> GCrm_Users { get; set; }
        public DbSet<UserTitle> GCrm_UserTitle { get; set; }
        public DbSet<Project> GCrm_Projects { get; set; }
        public DbSet<ProjectManager> GCrm_ProjectManagers { get; set; }
        public DbSet<ProjectTeam> GCrm_ProjectTeams { get; set; }
        public DbSet<ProjectType> GCrm_ProjectType { get; set; }
        public DbSet<ProjectStatues> GCrm_ProjectStatues { get; set; }

        public DbSet<Opportunity> GCrm_Opportunities { get; set; }

        public DbSet<OpportunitySector> GCrm_OpportunitySectors { get; set; }

        //public DbSet<Employee> Employees { get; set; }

        public DbSet<CompanyTender> GCrm_CompanyTenders { get; set; }

        public DbSet<CompanyOffer> GCrm_CompanyOffers { get; set; }

        public DbSet<CompanyContactName> GCrm_CompanyContactNames { get; set; }

        public DbSet<SolutionOffer> GCrm_SolutionOffers { get; set; }

        public DbSet<OpportunityReference> GCrm_OpportunityReferences { get; set; }

        public DbSet<OpportunityStage> GCrm_OpportunityStages { get; set; }

        public DbSet<ProductBrand> GCrm_ProductBrands { get; set; }

        public DbSet<ProductCategory> GCrm_ProductCategories { get; set; }

        public DbSet<Product> GCrm_Products { get; set; }

        public DbSet<ProductMainCategory> GCrm_ProductMainCategories { get; set; }

        public DbSet<ProductManufacturer> GCrm_ProductManufacturers { get; set; }

        public DbSet<ProductModel> GCrm_ProductModels { get; set; }

        public DbSet<ProductSubCategory> GCrm_ProductSubCategories { get; set; }

        public DbSet<ProductType> GCrm_ProductTypes { get; set; }

    


        #region Files

        //public DbSet<AppFile> AppFiles { get; set; }

        public DbSet<CustomerActivityFile> GCrm_CustomerActivityFiles { get; set; }

        public DbSet<CustomerContactFile> GCrm_CustomerContactFiles { get; set; }

        public DbSet<CustomerFile> GCrm_CustomerFiles { get; set; }



        #endregion

        #endregion

        #endregion

        #region NLLogistics

        #region Definitions

        public DbSet<Airline> NL_Airlines { get; set; }

        public DbSet<Airport> NL_Airports { get; set; }

        public DbSet<Port> NL_Ports { get; set; }

        public DbSet<Vessel> NL_Vessels { get; set; }

        public DbSet<Voyage> NL_Voyages { get; set; }


        #endregion

        #endregion

        public void BaseProjectUpdateDatabase(string dbName)
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
                switch (data.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    case EntityState.Modified:
                        if (data.Entity.IsDeleted)
                        {
                            data.Entity.DeletedBy = await GetCurrentUserNameIdentifierAsync();
                            data.Entity.DeletedDate = DateTime.Now;
                        }
                        else
                        {
                            data.Entity.UpdatedBy = await GetCurrentUserNameIdentifierAsync();
                            data.Entity.UpdatedDate = DateTime.Now;
                        }
                        break;
                    case EntityState.Added:
                        data.Entity.CreatedBy = await GetCurrentUserNameIdentifierAsync();
                        data.Entity.CreatedDate = DateTime.Now;
                        break;
                    default:
                        break;
                }
            }
            #endregion
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region BaseProject

            ConfigureB_BaseEntity<Company>(builder);
            ConfigureB_BaseEntity<AppUserLicense>(builder);
            ConfigureB_BaseEntity<Branch>(builder);
            ConfigureB_BaseEntity<City>(builder);
            ConfigureB_BaseEntity<Company>(builder);
            ConfigureB_BaseEntity<CompanyLicense>(builder);
            ConfigureB_BaseEntity<Country>(builder);
            ConfigureB_BaseEntity<Domain.Entities.Definitions.Department>(builder);
            ConfigureB_BaseEntity<District>(builder);
            ConfigureB_BaseEntity<MailCredantial>(builder);
            ConfigureB_BaseEntity<AddressType>(builder);
            ConfigureB_BaseEntity<AddressType>(builder);

            #endregion

            #region GControl
            builder.Entity<Announcement>()
                  .HasMany(a => a.EmployeeLabels)
                  .WithMany(e => e.Announcements)
                  .UsingEntity(join => join.ToTable("GControl_AnnouncementEmployeeLabel"));

            builder.Entity<Announcement>()
                   .HasMany(a => a.Departments)
                   .WithMany(d => d.Announcements)
                   .UsingEntity(join => join.ToTable("GControl_AnnouncementDepartment"));

            builder.Entity<Domain.Entities.GControl.Definitions.Employee>()
                   .HasMany(a => a.ShiftManagements)
                   .WithMany(d => d.Employees)
                   .UsingEntity(join => join.ToTable("GControl_EmployeeShiftManagement"));

            builder.Entity<Domain.Entities.GControl.Definitions.Employee>()
                  .HasMany(a => a.EmployeeLabels)
                  .WithMany(d => d.Employees)
                  .UsingEntity(join => join.ToTable("GControl_EmployeeEmployeeLabel"));

            builder.Entity<ApplicationSetting>()
                  .HasMany(a => a.Employees)
                  .WithMany(d => d.ApplicationSettings)
                  .UsingEntity(join => join.ToTable("GControl_ApplicationSettingEmployee"));

            builder.Entity<Domain.Entities.GControl.Definitions.Employee>()
                  .HasMany(a => a.EmployeeFiles)
                  .WithMany(d => d.Employees)
                  .UsingEntity(join => join.ToTable("GControl_EmployeeEmployeeFile"));

            #endregion

            #region GCard

            builder.Entity<OrderDetail>()
                        .HasOne(od => od.Order)
                        .WithMany(o => o.OrderDetails)
                        .HasForeignKey(od => od.OrderId)
                        .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderDetail>()
                        .HasOne(od => od.Staff)
                        .WithMany()
                        .HasForeignKey(od => od.PurchasedForStaffId)
                        .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Invoice>()
                        .HasOne(i => i.Order)
                        .WithOne(o => o.Invoice)
                        .HasForeignKey<Order>(o => o.InvoiceId);

            builder.Entity<Domain.Entities.GCard.Definitions.Files.StaffFile>()
               .HasMany(a => a.Staffs)
               .WithMany(d => d.StaffFiles)
               .UsingEntity(join => join.ToTable("GCard_StaffStaffFile"));

            #endregion

            #region GHR

            //builder.Entity<Appellation>().HasData(Configuration.GHRSeedData.Appellations);
            //builder.Entity<LeaveType>().HasData(Configuration.GHRSeedData.LeaveTypes);
            //builder.Entity<Leave>().HasData(Configuration.GHRSeedData.Leaves);
            //builder.Entity<Employee>().HasData(Configuration.GHRSeedData.Employees);
            //builder.Entity<Payroll>().HasData(Configuration.GHRSeedData.Payrolls);
            //builder.Entity<JobAdvert>().HasData(Configuration.GHRSeedData.JobAdverts);
            //builder.Entity<JobAdvertPostedOn>().HasData(Configuration.GHRSeedData.JobAdvertPostedOns);
            #endregion

            #region GCrm
            builder.Entity<Customer>()
                 .HasMany(a => a.CustomerCategories)
                 .WithMany(e => e.Customers)
                 .UsingEntity(join => join.ToTable("GCrm_CustomersCustomerCategories"));

            //builder.Entity<Opportunity>()
            //    .HasMany(a => a.Users)
            //    .WithMany(e => e.Opportunities)
            //    .UsingEntity(join => join.ToTable("GCrm_OpportunityUsers"));

            builder.Entity<Project>()
               .HasMany(a => a.ProjectFiles)
               .WithMany(e => e.Projects)
               .UsingEntity(join => join.ToTable("GCrm_ProjectProjectFiles"));
            #endregion

            base.OnModelCreating(builder);
        }

        private void ConfigureB_BaseEntity<T>(ModelBuilder modelBuilder) where T : B_BaseEntity
        {
            modelBuilder.Entity<T>()
                .HasOne(e => e.CreatedByUser)
                .WithMany()
                .HasForeignKey(e => e.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<T>()
                .HasOne(e => e.UpdatedByUser)
                .WithMany()
                .HasForeignKey(e => e.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<T>()
                .HasOne(e => e.DeletedByUser)
                .WithMany()
                .HasForeignKey(e => e.DeletedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}