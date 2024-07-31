﻿using Utilities.Core.UtilityDomain.Entities;

namespace BaseProject.Domain.Entities.GCrm.Definitions.OpportunityManagement.Opportunity
{
    public class SolutionOffer : BaseEntity
    {
        public string Name { get; set; }
        public Opportunity Opportunity { get; set; }
    }
}