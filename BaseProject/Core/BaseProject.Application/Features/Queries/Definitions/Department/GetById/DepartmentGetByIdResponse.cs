namespace BaseProject.Application.Features.Queries.Definitions.Department.GetById
{
    public class DepartmentGetByIdResponse
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string? MainDepartmentId { get; set; }

    }
}
