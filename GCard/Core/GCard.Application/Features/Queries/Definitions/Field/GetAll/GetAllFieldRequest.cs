﻿using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.Field.GetAll
{
    public class GetAllFieldRequest : Pagination, IRequest<GetAllFieldResponse>
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
    }
}
