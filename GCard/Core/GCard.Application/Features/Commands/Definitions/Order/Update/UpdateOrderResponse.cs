﻿using Utilities.Core.UtilityApplication.Enums;

namespace GCard.Application.Features.Commands.Definitions.Order.Update
{
    public class UpdateOrderResponse
    {
        public string Id { get; set; }
        public string StaffId { get; set; }
        public string AddressId { get; set; }
        public string CargoId { get; set; }
        public string? InvoiceId { get; set; }
        public OrderStatus Status { get; set; }
        public decimal? GeneralAmount { get; set; }
        public string BaseProjectCompanyId { get; set; }
        public string BaseProjectBranchId { get; set; }
        public string Message { get; set; }
    }
}
