﻿using MediatR;

namespace GCard.Application.Features.Queries.Definitions.Order.GetById
{
    public class GetByIdOrderRequest : IRequest<GetByIdOrderResponse>
    {
        public string Id { get; set; }
    }
}
