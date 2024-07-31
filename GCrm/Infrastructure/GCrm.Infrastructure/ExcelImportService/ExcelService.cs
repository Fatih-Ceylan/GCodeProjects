using GCrm.Application.Features.Commands.Definitions.CustomerExcel.Create;
using MediatR;

namespace GCrm.Infrastructure.ExcelImportService
{
    public  class ExcelService
    {
        private readonly IMediator _mediator;

        public ExcelService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<CreateCustomerExcelResponse> ImportExcel(string filePath)
        {
            var command = new CreateCustomerExcelRequest { FilePath = filePath };
            var result = await _mediator.Send(command);
            return result;
        }
    }
}
