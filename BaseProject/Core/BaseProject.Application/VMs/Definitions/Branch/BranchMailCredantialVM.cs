using BaseProject.Application.VMs.Definitions.MailCredantial;
using Utilities.Core.UtilityApplication.VMs;

namespace BaseProject.Application.VMs.Definitions.Branch
{
    public class BranchMailCredantialVM: BaseVM
    {
        public string Name { get; set; }

        public MailCredantialUpdateVM? MailCredantial { get; set; }

    }
}