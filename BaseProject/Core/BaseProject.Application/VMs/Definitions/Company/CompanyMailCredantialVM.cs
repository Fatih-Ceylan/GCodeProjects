using BaseProject.Application.VMs.Definitions.Branch;
using Utilities.Core.UtilityApplication.VMs;

namespace BaseProject.Application.VMs.Definitions.Company
{
    public class CompanyMailCredantialVM: BaseVM
    {
        public string Name { get; set; }

        public int BranchCount { get; set; }

        public List<BranchMailCredantialVM>? Branches { get; set; }

    }
}
