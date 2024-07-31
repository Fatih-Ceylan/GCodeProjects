using BaseProject.Domain.Entities.GHR.Recruitment.Jobs;
using BaseProject.Domain.Entities.GHR.Recruitment.TestDetails;

namespace BaseProject.Domain.Entities.GHR.Recruitment.Applications
{
    public class JobApplicationTest : B_BaseEntity
    {
        public Guid JobApplicationId { get; set; }

        public Guid TestId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ICollection<JobAdvert> JobApplications { get; set; }

        public ICollection<Test> Tests { get; set; }

        public ICollection<TestAnswers> TestAnswers { get; set; }
    }
}
