using MediatR;

namespace GCard.Application.Features.Queries.Definitions.StaffFile.GetFileListByStaffId
{
    public class GetFileListByStaffIdRequest: IRequest<GetFileListByStaffIdResponse>
    {
        public string Id { get; set; }
    }
}
