using GHR.Application.Repositories.ReadRepository;
using GHR.Application.VMs.Definitions;
using MediatR;

namespace GHR.Application.Features.Queries.Definitions.Appellation.GetById
{
    public class GetByIdAppellationHandler : IRequestHandler<GetByIdAppellationRequest, GetByIdAppellationResponse>
    {
        public IAppellationReadRepository _appellationReadRepository;

        public GetByIdAppellationHandler(IAppellationReadRepository appellationReadRepository)
        {
            _appellationReadRepository = appellationReadRepository;
        }

        public async Task<GetByIdAppellationResponse> Handle(GetByIdAppellationRequest request, CancellationToken cancellationToken)
        {
            var appellation = _appellationReadRepository
                              .GetWhere(c => c.Id == Guid.Parse(request.Id), false)
                              .Select(c => new AppellationVM
                              {
                                  Id = c.Id.ToString(),
                                  Code = c.Code,
                                  Name = c.Name,
                                  MainAppellationId = c.MainAppellationId.ToString(),
                                  CreatedDate = c.CreatedDate,
                              }).FirstOrDefault();

            return new()
            {
                Appellation = appellation
            };
        }
    }
}
