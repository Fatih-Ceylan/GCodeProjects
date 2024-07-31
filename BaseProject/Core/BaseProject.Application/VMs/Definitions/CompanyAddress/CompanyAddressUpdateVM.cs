using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Application.VMs.Definitions.CompanyAddress
{
    public class CompanyAddressUpdateVM
    {
        public string Id { get; set; }

        public string AddressTypeId { get; set; }

        public string? CountryId { get; set; }

        public string? CityId { get; set; }

        public string? DistrictId { get; set; }

        public string? PostalCode { get; set; }

        public string? FullAddress { get; set; }

    }
}
