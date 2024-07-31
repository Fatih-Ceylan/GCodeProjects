using AutoMapper;
using GHR.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;

namespace GHR.Application.Features.Commands.Definitions.Recruitment.Jobs.JobAdvert.Create
{
    public class CreateJobAdvertHandler : IRequestHandler<CreateJobAdvertRequest, CreateJobAdvertResponse>
    {
        readonly IMapper _mapper;
        readonly IJobAdvertWriteRepository _jobAdvertWriteRepository;

        public CreateJobAdvertHandler(IMapper mapper, IJobAdvertWriteRepository jobAdvertWriteRepository)
        {
            _mapper = mapper;
            _jobAdvertWriteRepository = jobAdvertWriteRepository;
        }

        public async Task<CreateJobAdvertResponse> Handle(CreateJobAdvertRequest request, CancellationToken cancellationToken)
        {
            var jobAdvert = _mapper.Map<BaseProject.Domain.Entities.GHR.Recruitment.Jobs.JobAdvert>(request);
            jobAdvert = await _jobAdvertWriteRepository.AddAsync(jobAdvert);
            await _jobAdvertWriteRepository.SaveAsync();

            var createdResponse = _mapper.Map<CreateJobAdvertResponse>(jobAdvert);
            createdResponse.Message = CommandResponseMessage.AddedSuccess.ToString();

            return createdResponse;
        }
    }
}
