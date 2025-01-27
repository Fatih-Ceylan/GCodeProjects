﻿using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.Address.GetAll
{
    public class GetAllAddressRequest : Pagination, IRequest<GetAllAddressResponse>
    {
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
    }
}
