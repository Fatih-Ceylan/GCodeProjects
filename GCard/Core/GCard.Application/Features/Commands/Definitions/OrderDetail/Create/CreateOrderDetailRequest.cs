﻿using GCard.Application.VMs;
using MediatR;

namespace GCard.Application.Features.Commands.Definitions.OrderDetail.Create
{
    public class CreateOrderDetailRequest : IRequest<CreateOrderDetailResponse>
    {
        public List<CreateOrderDetailVM> OrderDetails { get; set; }
        public CreateOrderVM Order { get; set; }
        public List<CreateAddressVM> Addresses { get; set; }
    }
}
