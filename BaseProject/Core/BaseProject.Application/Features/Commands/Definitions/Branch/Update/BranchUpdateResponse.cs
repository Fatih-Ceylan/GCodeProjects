namespace BaseProject.Application.Features.Commands.Definitions.Branch.Update
{
    public class BranchUpdateResponse
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string CompanyId { get; set; }

        public string Message { get; set; } = "Updated Success";
    }
}