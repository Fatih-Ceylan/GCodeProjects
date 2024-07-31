namespace BaseProject.Domain.Entities.GHR.Recruitment.Applications
{
    public class JobApplicationStatusHistory : B_BaseEntity
    {

        public Guid JobApplicationStatusId { get; set; }

        public DateTime StatusTime { get; set; }

        public JobApplicationStatus JobApplicationStatus { get; set; }
    }
}
