using BaseProject.Domain.Entities.GHR.Recruitment.Applications;
using Utilities.Core.UtilityDomain.Entities.Files;

namespace BaseProject.Domain.Entities.GHR.Files
{
    public class JobApplicantDocument : AppFile
    {
        public ICollection<JobApplicant> JobApplicants { get; set; }
    }
}
