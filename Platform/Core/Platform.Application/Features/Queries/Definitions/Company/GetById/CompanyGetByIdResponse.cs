using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Application.Features.Queries.Definitions.Company.GetById
{
    public class CompanyGetByIdResponse
    {
        public string Id { get; set; }

        public string? LogoPath { get; set; }

        public string Name { get; set; }

        public string BaseDbName { get; set; }

        public string AuthorizedFullName { get; set; }

        public string? FullAddress { get; set; }

        public string? PostalCode { get; set; }

        public string? PhoneNumber { get; set; }

        public string? FaxNo { get; set; }

        public string? Email { get; set; }

        public string? WebAddress { get; set; }

        public string? TaxOffice { get; set; }

        public string? TaxNo { get; set; }

        public string? TradeRegisterNo { get; set; }

        public string? SocialSecurityNo { get; set; }

        public string? MersisNo { get; set; }

        public string AdminUserFullName { get; set; }

        public string AdminUserEmail { get; set; }

        public string AdminUserPassword { get; set; }

        public string AdminUserPasswordConfirm { get; set; }

        public string Message { get; set; }
    }
}
