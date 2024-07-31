using BaseProject.Application.VMs.Definitions.MailCredantial;

namespace BaseProject.Application.Features.Queries.Definitions.MailCredantial.GetAll
{
    public class GetAllMailCredantialResponse
    {
        public int TotalCount { get; set; }

        public List<MailCredantialVM> MailCredantials { get; set; }
    }
}