using BaseProject.Domain.Entities.GHR.Recruitment.Applications;

namespace BaseProject.Domain.Entities.GHR.Recruitment.TestDetails
{
    public class TestProcess : B_BaseEntity
    {
        public string ProcessName { get; set; }

        public ICollection<JobApplication> JobApplications { get; set; }
    }
}
