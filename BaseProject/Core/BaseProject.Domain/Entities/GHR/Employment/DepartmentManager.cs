namespace BaseProject.Domain.Entities.GHR.Employment
{
    public class DepartmentManager : B_BaseEntity
    {
        public Guid DepartmentId { get; set; }

        public Guid EmployeeId { get; set; }
    }
}
