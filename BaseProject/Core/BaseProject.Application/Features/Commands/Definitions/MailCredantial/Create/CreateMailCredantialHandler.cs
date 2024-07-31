using AutoMapper;
using BaseProject.Application.Repositories.WriteRepository.Definitions;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;
using T = BaseProject.Domain.Entities.Definitions;

namespace BaseProject.Application.Features.Commands.Definitions.MailCredantial.Create
{
    public class CreateMailCredantialHandler : IRequestHandler<CreateMailCredantialRequest, CreateMailCredantialResponse>
    {
        readonly IMapper _mapper;
        readonly IMailCredantialWriteRepository _mailCredantialWriteRepository;
        //readonly ISha256Service _sha256Service;

        public CreateMailCredantialHandler(IMapper mapper, IMailCredantialWriteRepository mailCredantialWriteRepository)
        {
            _mapper = mapper;
            _mailCredantialWriteRepository = mailCredantialWriteRepository;
        }

        public async Task<CreateMailCredantialResponse> Handle(CreateMailCredantialRequest request, CancellationToken cancellationToken)
        {
            T.MailCredantial mailCredantial = _mapper.Map<T.MailCredantial>(request);
            //TODO password encrypt ve decrypt olayı yapılacak.
            //mailCredantial.FromPassword = _sha256Service.PasswordEncrypt(request.FromPassword);
            mailCredantial = await _mailCredantialWriteRepository.AddAsync(mailCredantial);
            await _mailCredantialWriteRepository.SaveAsync();

            var createdResponse = _mapper.Map<CreateMailCredantialResponse>(mailCredantial);
            createdResponse.Message = CommandResponseMessage.AddedSuccess.ToString();

            return createdResponse;
        }
    }
}