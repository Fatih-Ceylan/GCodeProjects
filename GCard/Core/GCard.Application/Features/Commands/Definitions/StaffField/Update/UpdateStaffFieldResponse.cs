﻿namespace GCard.Application.Features.Commands.Definitions.StaffField.Update
{
    public class UpdateStaffFieldResponse
    {
        public string Id { get; set; }
        public string FieldId { get; set; }
        public int RowNumber { get; set; }
        public string StaffId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string Message { get; set; }
    }
}
