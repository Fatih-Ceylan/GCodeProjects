using MediatR;
using Utilities.Core.UtilityApplication.RequestParameters;

namespace BaseProject.Application.Features.Queries.Definitions.MailCredantial.GetAll
{
    public class GetAllMailCredantialRequest: Pagination,IRequest<GetAllMailCredantialResponse>
    {
        
    }
}
