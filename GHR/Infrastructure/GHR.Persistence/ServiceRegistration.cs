using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.ReadRepository;
using GHR.Application.Repositories.WriteRepository;
using GHR.Persistence.Repositories.ReadRepository;
using GHR.Persistence.Repositories.WriteRepository;
using Microsoft.Extensions.DependencyInjection;


namespace GHR.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddGHRPersistenceServices(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddDbContext<BaseProjectDbContext>();

            #region Appellation
            services.AddScoped<IAppellationReadRepository, AppellationReadRepository>();
            services.AddScoped<IAppellationWriteRepository, AppellationWriteRepository>();
            #endregion

            #region Employee
            services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();
            services.AddScoped<IEmployeeWriteRepository, EmployeeWriteRepository>();
            #endregion

            #region Leave
            services.AddScoped<ILeaveReadRepository, LeaveReadRepository>();
            services.AddScoped<ILeaveWriteRepository, LeaveWriteRepository>();
            #endregion

            #region LeaveType
            services.AddScoped<ILeaveTypeReadRepository, LeaveTypeReadRepository>();
            services.AddScoped<ILeaveTypeWriteRepository, LeaveTypeWriteRepository>();
            #endregion

            #region EducationInfo
            services.AddScoped<IEducationInfoReadRepository, EducationInfoReadRepository>();
            services.AddScoped<IEducationInfoWriteRepository, EducationInfoWriteRepository>();
            #endregion

            #region Payroll
            services.AddScoped<IPayrollReadRepository, PayrollReadRepository>();
            services.AddScoped<IPayrollWriteRepository, PayrollWriteRepository>();
            #endregion

            #region Location
            //services.AddScoped<ILocationReadRepository, LocationReadRepository>();
            services.AddScoped<ILocationWriteRepository, LocationWriteRepository>();

            #endregion

            #region JobAdvert
            services.AddScoped<IJobAdvertReadRepository, JobAdvertReadRepository>();
            services.AddScoped<IJobAdvertWriteRepository, JobAdvertWriteRepository>();
            #endregion

            #region JobApplicant
            services.AddScoped<IJobApplicantReadRepository, JobApplicantReadRepository>();
            services.AddScoped<IJobApplicantWriteRepository, JobApplicantWriteRepository>();
            #endregion

            #region JobApplication
            services.AddScoped<IJobApplicationReadRepository, JobApplicationReadRepository>();
            services.AddScoped<IJobApplicationWriteRepository, JobApplicationWriteRepository>();
            #endregion

            #region JobApplicationStatus
            services.AddScoped<IJobApplicationStatusReadRepository, JobApplicationStatusReadRepository>();
            services.AddScoped<IJobApplicationStatusWriteRepository, JobApplicationStatusWriteRepository>();
            #endregion

            #region JobApplicationStatusHistory
            services.AddScoped<IJobApplicationStatusHistoryReadRepository, JobApplicationStatusHistoryReadRepository>();
            services.AddScoped<IJobApplicationStatusHistoryWriteRepository, JobApplicationStatusHistoryWriteRepository>();
            #endregion

            //services.AddSingleton<IRedisCacheService, RedisCacheService>();
        }
    }
}
