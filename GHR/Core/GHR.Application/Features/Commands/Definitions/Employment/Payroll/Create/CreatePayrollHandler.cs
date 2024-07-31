using AutoMapper;
using GHR.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;

namespace GHR.Application.Features.Commands.Definitions.Employment.Payroll.Create
{
    public class CreatePayrollHandler : IRequestHandler<CreatePayrollRequest, CreatePayrollResponse>
    {
        readonly IPayrollWriteRepository _payrollWriteRepository;
        readonly IMapper _mapper;

        public CreatePayrollHandler(IPayrollWriteRepository PayrollWriteRepository, IMapper mapper)
        {
            _payrollWriteRepository = PayrollWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreatePayrollResponse> Handle(CreatePayrollRequest request, CancellationToken cancellationToken)
        {
            var Payroll = _mapper.Map<BaseProject.Domain.Entities.GHR.Employment.Payroll>(request);

            Payroll = await _payrollWriteRepository.AddAsync(Payroll);
            await _payrollWriteRepository.SaveAsync();

            var createdResponse = _mapper.Map<CreatePayrollResponse>(Payroll);
            createdResponse.Message = CommandResponseMessage.AddedSuccess.ToString();

            return createdResponse;
        }
    }
}
