using AutoMapper;
using MediatR;
using Platform.Application.Repositories.WriteRepository.Definitions;
using T = Platform.Domain.Entities.Definitions;

namespace Platform.Application.Features.Commands.Definitions.Licence.Create
{
    public class LicenceCreateHandler : IRequestHandler<LicenceCreateRequest, LicenceCreateREsponse>
    {
        readonly ILicenceWriteRepository _licenceWriteRepository;
        readonly IMapper _mapper;

        public LicenceCreateHandler(ILicenceWriteRepository licenceWriteRepository, IMapper mapper)
        {
            _licenceWriteRepository = licenceWriteRepository;
            _mapper = mapper;
        }

        public async Task<LicenceCreateREsponse> Handle(LicenceCreateRequest request, CancellationToken cancellationToken)
        {
            T.Licence licence = _mapper.Map<T.Licence>(request);

            await _licenceWriteRepository.AddAsync(licence);
            await _licenceWriteRepository.SaveAsync();

            return new();
        }
    }
}

