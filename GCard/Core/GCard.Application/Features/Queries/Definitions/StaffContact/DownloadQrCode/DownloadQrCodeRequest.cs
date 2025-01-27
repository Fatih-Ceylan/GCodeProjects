﻿using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GCard.Application.Features.Queries.Definitions.StaffContact.DownloadQrCode
{
    public class DownloadQrCodeRequest : Pagination, IRequest<DownloadQrCodeResponse>
    {
        public string Id { get; set; }
    }
}
