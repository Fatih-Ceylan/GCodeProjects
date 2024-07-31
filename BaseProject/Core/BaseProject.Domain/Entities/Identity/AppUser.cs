using BaseProject.Domain.Entities.Definitions;
using BaseProject.Domain.Entities.GCrm.Definitions.CustomerManagement.Customers;
using BaseProject.Domain.Entities.GCrm.Definitions.OpportunityManagement.Opportunity;
using BaseProject.Domain.Entities.Identity.File;
using Microsoft.AspNetCore.Identity;

namespace BaseProject.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string FullName { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime? RefreshTokenEndDate { get; set; }

        public string? ProfileImagePath { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CompanyId { get; set; }

        public Guid? BranchId { get; set; }

        public Guid? DepartmentId { get; set; }

        public Department? Department { get; set; }

        public ICollection<MailCredantial> MailCredantials { get; set; }

        public ICollection<CompanyLicense> CompanyGModules { get; set; }

        public ICollection<AppUserFile> AppUserFiles { get; set; }

        public ICollection<AppUserLicense> AppUserLicenses { get; set; }

        public ICollection<Company> Companies { get; set; }

        #region GCRM
        public ICollection<Customer>? Customers { get; set; }
        public ICollection<Opportunity>? Opportunities { get; set; }
        #endregion

    }
}