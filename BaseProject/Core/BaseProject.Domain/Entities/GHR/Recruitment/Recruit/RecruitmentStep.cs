using BaseProject.Domain.Entities.GHR.Recruitment.Jobs;

namespace BaseProject.Domain.Entities.GHR.Recruitment.Recruit
{
    public class RecruitmentStep : B_BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public Guid JobAdvertId { get; set; }

        public JobAdvert JobAdvert { get; set; }

        public ICollection<RecruitmentProcessStep> RecruitmentProcessStep { get; set; }
    }
}
