using AutoMapper;
using GHR.Application.Repositories.ReadRepository;
using GHR.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Enums;

namespace GHR.Application.Features.Commands.Definitions.Employment.Payroll.Update
{
    public class UpdatePayrollHandler : IRequestHandler<UpdatePayrollRequest, UpdatePayrollResponse>
    {
        public IMapper _mapper;
        public IPayrollReadRepository _payrollReadRepository;
        public IPayrollWriteRepository _payrollWriteRepository;

        public UpdatePayrollHandler(IMapper mapper, IPayrollReadRepository PayrollReadRepository, IPayrollWriteRepository PayrollWriteRepository)
        {
            _mapper = mapper;
            _payrollReadRepository = PayrollReadRepository;
            _payrollWriteRepository = PayrollWriteRepository;
        }

        public async Task<UpdatePayrollResponse> Handle(UpdatePayrollRequest request, CancellationToken cancellationToken)
        {
            var Payroll = await _payrollReadRepository.GetByIdAsync(request.Id);
            Payroll = _mapper.Map(request, Payroll);
            await _payrollWriteRepository.SaveAsync();

            var updatedResponse = _mapper.Map<UpdatePayrollResponse>(Payroll);
            updatedResponse.Message = CommandResponseMessage.UpdatedSuccess.ToString();

            return updatedResponse;
        }
    }
}
