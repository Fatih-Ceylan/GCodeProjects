using AutoMapper;
using GCard.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;
using T = BaseProject.Domain.Entities.GCard.Definitions;

namespace GCard.Application.Features.Commands.Definitions.Address.Create
{
    public class CreateAddressHandler : IRequestHandler<CreateAddressRequest, CreateAddressResponse>
    {
        readonly IAddressWriteRepository _addressWriteRepository;
        readonly IMapper _mapper;

        public CreateAddressHandler(IAddressWriteRepository addressWriteRepository, IMapper mapper)
        {
            _addressWriteRepository = addressWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateAddressResponse> Handle(CreateAddressRequest request, CancellationToken cancellationToken)
        {
            T.Address address = _mapper.Map<T.Address>(request);

            await _addressWriteRepository.AddAsync(address);
            await _addressWriteRepository.SaveAsync();

            var createdResponse = _mapper.Map<CreateAddressResponse>(address);
            createdResponse.Message = CommandResponseMessage.AddedSuccess.ToString(); 

            return createdResponse;
        }
    }
}
