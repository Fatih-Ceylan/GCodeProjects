using AutoMapper;
using GCard.Application.Repositories.ReadRepository;
using GCard.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;
using T = BaseProject.Domain.Entities.GCard.Definitions;

namespace GCard.Application.Features.Commands.Definitions.Iban.Update
{
    public class UpdateIbanHandler : IRequestHandler<UpdateIbanRequest, UpdateIbanResponse>
    {
        readonly IIbanWriteRepository _ibanWriteRepository;
        readonly IIbanReadRepository _ibanReadRepository;
        readonly IMapper _mapper;

        public UpdateIbanHandler(IIbanWriteRepository ibanWriteRepository, IIbanReadRepository ibanReadRepository, IMapper mapper)
        {
            _ibanWriteRepository = ibanWriteRepository;
            _ibanReadRepository = ibanReadRepository;
            _mapper = mapper;
        }

        public async Task<UpdateIbanResponse> Handle(UpdateIbanRequest request, CancellationToken cancellationToken)
        {
            T.Iban iban = await _ibanReadRepository.GetByIdAsync(request.Id);
            iban = _mapper.Map(request, iban);
            await _ibanWriteRepository.SaveAsync();

            var updatedResponse = _mapper.Map<UpdateIbanResponse>(iban);
            updatedResponse.Message = CommandResponseMessage.UpdatedSuccess.ToString();

            return updatedResponse;
        }
    }
}
