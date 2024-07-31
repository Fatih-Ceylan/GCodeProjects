using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Domain.Entities.GControl.Definitions;

namespace BaseProject.Domain.Entities.Definitions
{
    public class Branch : B_BaseEntity
    {
        public Guid CompanyId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string? AuthorizedFullName { get; set; }

        public string? FullAddress { get; set; }

        public string? PostalCode { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public int? CountryId { get; set; }

        public int? CityId { get; set; }

        public int? DistrictId { get; set; }

        public Company Company { get; set; }

        public District? District { get; set; }

        public ICollection<Department> Departments { get; set; }

        public ICollection<MailCredantial> MailCredantials { get; set; }

        #region GCard

        public ICollection<Address> GCardAddresses { get; set; }
        public ICollection<Cargo> GCardCargos { get; set; }
        public ICollection<Field> GCardFields { get; set; }
        public ICollection<Iban> GCardIbans { get; set; }
        public ICollection<Invoice> GCardInvoices { get; set; }
        public ICollection<Order> GCardOrders { get; set; }
        public ICollection<OrderDetail> GCardDetails { get; set; }
        public ICollection<PhoneNumber> GCardPhoneNumbers { get; set; }
        public ICollection<SocialMedia> GCardSocialMedias { get; set; }
        public ICollection<SocialMediaUrl> GCardSocialMediaUrls { get; set; }
        public ICollection<Staff> GCardStaffs { get; set; }
        public ICollection<StaffContact> GCardStaffContacts { get; set; }
        public ICollection<StaffField> GCardStaffFields { get; set; }

        #endregion

        #region GControl
        public ICollection<Employee> GControlEmployees { get; set; }
        public ICollection<EntryExitManagement> GControlEntryExitManagement { get; set; }
        #endregion

    }
}