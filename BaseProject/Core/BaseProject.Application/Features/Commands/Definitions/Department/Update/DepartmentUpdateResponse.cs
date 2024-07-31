namespace BaseProject.Application.Features.Commands.Definitions.Department.Update
{
    public class DepartmentUpdateResponse
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string? MainDepartmentId { get; set; }

        public string Message { get; set; } = "Updated Success";
    }
}
