using BaseProject.Domain.Entities.GHR.Recruitment.Applications;

namespace BaseProject.Domain.Entities.GHR.Recruitment.TestDetails
{
    public class Test : B_BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public int MaxScore { get; set; }

        public ICollection<JobApplicationTest> JobApplicationTests { get; set; }
    }
}
