using AutoMapper;
using MediatR;
using Platform.Application.Repositories.ReadRepository.Definitions;
using T = Platform.Domain.Entities.Definitions;

namespace Platform.Application.Features.Queries.Definitions.Licence.GetById
{
    public class LicenceGetByIdHandler : IRequestHandler<LicenceGetByIdRequest, LicenceGetByIdResponse>
    {
        readonly IMapper _mapper;
        readonly ILicenceReadRepository _readRepository;

        public LicenceGetByIdHandler(IMapper mapper, ILicenceReadRepository readRepository)
        {
            _mapper = mapper;
            _readRepository = readRepository;
        }

        public async Task<LicenceGetByIdResponse> Handle(LicenceGetByIdRequest request, CancellationToken cancellationToken)
        {
            T.Licence licence = await _readRepository.GetByIdAsync(request.Id, false);
            return _mapper.Map<LicenceGetByIdResponse>(licence);
        }
    }
}
