using AutoMapper;
using GHR.Application.Repositories.ReadRepository;
using GHR.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;

namespace GHR.Application.Features.Commands.Definitions.Employment.Appellation.Update
{
    public class UpdateAppellationHandler : IRequestHandler<UpdateAppellationRequest, UpdateAppellationResponse>
    {
        public IMapper _mapper;
        public IAppellationReadRepository appellationReadRepository;
        public IAppellationWriteRepository appellationWriteRepository;

        public UpdateAppellationHandler(IMapper mapper, IAppellationReadRepository AppellationReadRepository, IAppellationWriteRepository AppellationWriteRepository)
        {
            _mapper = mapper;
            appellationReadRepository = AppellationReadRepository;
            appellationWriteRepository = AppellationWriteRepository;
        }

        public async Task<UpdateAppellationResponse> Handle(UpdateAppellationRequest request, CancellationToken cancellationToken)
        {
            var Appellation = await appellationReadRepository.GetByIdAsync(request.Id);
            Appellation = _mapper.Map(request, Appellation);
            await appellationWriteRepository.SaveAsync();

            var updatedResponse = _mapper.Map<UpdateAppellationResponse>(Appellation);
            updatedResponse.Message = CommandResponseMessage.UpdatedSuccess.ToString();

            return updatedResponse;
        }
    }
}
