using BaseProject.Application.Repositories.WriteRepository.Definitions;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;

namespace BaseProject.Application.Features.Commands.Definitions.MailCredantial.Delete
{
    public class DeleteMailCredantialHandler : IRequestHandler<DeleteMailCredantialRequest, DeleteMailCredantialResponse>
    {
        readonly IMailCredantialWriteRepository _mailCredantialWriteRepository;

        public DeleteMailCredantialHandler(IMailCredantialWriteRepository mailCredantialWriteRepository)
        {
            _mailCredantialWriteRepository = mailCredantialWriteRepository;
        }

        public async Task<DeleteMailCredantialResponse> Handle(DeleteMailCredantialRequest request, CancellationToken cancellationToken)
        {
            await _mailCredantialWriteRepository.SoftDeleteAsync(request.Id);
            await _mailCredantialWriteRepository.SaveAsync();

            return new()
            {
                Message = CommandResponseMessage.DeletedSuccess.ToString()
            };
        }
    }
}