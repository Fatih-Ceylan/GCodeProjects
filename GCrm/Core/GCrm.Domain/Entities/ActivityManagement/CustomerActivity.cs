using GCrm.Domain.Entities.ActivityManagement.Files;
using GCrm.Domain.Entities.CustomerManagement;
using GCrm.Domain.Entities.Definitions.Activities;
using Utilities.Core.UtilityDomain.Entities;

namespace GCrm.Domain.Entities.ActivityManagement
{
    public class CustomerActivity : BaseEntity
    {
        public Guid CustomerId { get; set; }

        public Guid CustomerContactId { get; set; }

        public Guid CustomerActivityTypeId { get; set; }

        public Guid CustomerActivityKindId { get; set; }

        public Guid CustomerActivityStatusId { get; set; }

        public DateTime? ActivityDate { get; set; }

        public DateTime? ReminderDate { get; set; }

        public string ActivityAddress { get; set; }

        public string ActivityDescription { get; set; }
    
        //public Guid CustomerSubjectId { get; set; }
        //public Guid OpportunityId { get; set; }
        //public Guid CustomerOfferId { get; set; }
        //public Guid CustomerProjectId { get; set; }
        //public Guid CustomerActivityTeamId { get; set; }
        public Customer Customer { get; set; }

        //public CustomerSubject CustomerSubject { get; set; }
        public CustomerActivityKind CustomerActivityKind { get; set; }
        public CustomerActivityType CustomerActivityType { get; set; }
        public CustomerActivityStatus CustomerActivityStatus { get; set; }
        public ICollection<CustomerActivityFile> CustomerActivityFiles { get; set; }

        //public CustomerOffer? CustomerOffer { get; set; }
        //public CustomerProject? CustomerProject { get; set; }
        //public CustomerActivityTeam CustomerActivityTeam { get; set; }
        //public Opportunity Opportunity { get; set; }
    }
}
