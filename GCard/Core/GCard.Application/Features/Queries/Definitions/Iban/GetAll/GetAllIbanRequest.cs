﻿using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.Iban.GetAll
{
    public class GetAllIbanRequest : Pagination, IRequest<GetAllIbanResponse>
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
    }
}
