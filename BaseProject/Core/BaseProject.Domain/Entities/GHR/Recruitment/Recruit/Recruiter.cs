using BaseProject.Domain.Entities.GHR.Recruitment.Applications;

namespace BaseProject.Domain.Entities.GHR.Recruitment.Recruit
{
    public class Recruiter : B_BaseEntity
    {
        public string Code { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<JobApplication> JobApplications { get; set; }

        public ICollection<Notes> Notes { get; set; }
    }
}