using MediatR;
using Microsoft.AspNetCore.Http;

namespace GCard.Application.Features.Commands.Definitions.StaffFile.Create
{
    public class CreateStaffFileRequest : IRequest<CreateStaffFileResponse>
    {
        public string Id { get; set; }
        public IFormFileCollection? Files { get; set; }
    }
}
