﻿using MediatR;

namespace GCard.Application.Features.Queries.Definitions.Order.GetStaffAndQrListByOrderId
{
    public class GetStaffAndQrListByOrderIdRequest : IRequest<GetStaffAndQrListByOrderIdResponse>
    {
        public List<string> Ids { get; set; }
    }
}
