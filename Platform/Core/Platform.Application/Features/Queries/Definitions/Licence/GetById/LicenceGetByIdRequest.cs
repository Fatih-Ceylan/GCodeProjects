using MediatR;

namespace Platform.Application.Features.Queries.Definitions.Licence.GetById
{
    public class LicenceGetByIdRequest : IRequest<LicenceGetByIdResponse>
    {
        public string Id { get; set; }
    }
}
