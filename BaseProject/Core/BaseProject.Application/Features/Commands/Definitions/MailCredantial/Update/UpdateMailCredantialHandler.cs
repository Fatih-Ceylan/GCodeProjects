using AutoMapper;
using BaseProject.Application.Repositories.ReadRepository.Definitions;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using MediatR;
using Utilities.Core.UtilityApplication.Abstractions.Sha256;
using Utilities.Core.UtilityApplication.Enums;

namespace BaseProject.Application.Features.Commands.Definitions.MailCredantial.Update
{
    public class UpdateMailCredantialHandler : IRequestHandler<UpdateMailCredantialRequest, UpdateMailCredantialResponse>
    {
        readonly IMapper _mapper;
        readonly IMailCredantialReadRepository _mailCredantialReadRepository;
        readonly IMailCredantialWriteRepository _mailCredantialWriteRepository;
        readonly ISha256Service _sha256Service;

        public UpdateMailCredantialHandler(IMapper mapper, IMailCredantialReadRepository mailCredantialReadRepository, IMailCredantialWriteRepository mailCredantialWriteRepository, ISha256Service sha256Service)
        {
            _mapper = mapper;
            _mailCredantialReadRepository = mailCredantialReadRepository;
            _mailCredantialWriteRepository = mailCredantialWriteRepository;
            _sha256Service = sha256Service;
        }

        public async Task<UpdateMailCredantialResponse> Handle(UpdateMailCredantialRequest request, CancellationToken cancellationToken)
        {
            var mailCredantial = await _mailCredantialReadRepository.GetByIdAsync(request.Id); 
            mailCredantial = _mapper.Map(request, mailCredantial);
            await _mailCredantialWriteRepository.SaveAsync();

            var updatedResponse = _mapper.Map<UpdateMailCredantialResponse>(mailCredantial);
            updatedResponse.Message = CommandResponseMessage.UpdatedSuccess.ToString();

            return updatedResponse;
        }
    }
}