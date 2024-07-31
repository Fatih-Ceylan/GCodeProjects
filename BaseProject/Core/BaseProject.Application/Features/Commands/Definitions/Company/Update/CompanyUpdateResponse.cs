namespace BaseProject.Application.Features.Commands.Definitions.Company.Update
{
    public class CompanyUpdateResponse
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string? WebAddress { get; set; }

        public string? TaxNo { get; set; }

        public string? TaxOffice { get; set; }

        public string? TradeRegisterNo { get; set; }

        public string? SocialSecurityNo { get; set; }

        public string? MersisNo { get; set; }

        public string? LogoPath { get; set; }

        public string Message { get; set; } = "Updated Success";
    }
}
