using MediatR;

namespace BaseProject.Application.Features.Commands.Definitions.MailCredantial.Delete
{
    public class DeleteMailCredantialRequest: IRequest<DeleteMailCredantialResponse>
    {
        public string Id { get; set; }

    }
}