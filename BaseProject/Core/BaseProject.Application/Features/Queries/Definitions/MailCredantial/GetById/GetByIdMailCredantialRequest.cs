using MediatR;

namespace BaseProject.Application.Features.Queries.Definitions.MailCredantial.GetById
{
    public class GetByIdMailCredantialRequest: IRequest<GetByIdMailCredantialResponse>
    {
        public string Id { get; set; }
    }
}