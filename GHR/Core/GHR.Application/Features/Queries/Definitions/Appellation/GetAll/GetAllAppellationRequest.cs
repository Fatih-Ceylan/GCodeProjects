using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GHR.Application.Features.Queries.Definitions.Appellation.GetAll
{
    public class GetAllAppellationRequest : Pagination, IRequest<GetAllAppellationResponse>
    {
    }
}
