using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace GHR.Application.Features.Queries.Definitions.Jobs.JobAdvert.GetAll
{
    public class GetAllJobAdvertRequest : Pagination, IRequest<GetAllJobAdvertResponse>
    {
    }
}
