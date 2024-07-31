using GCard.Application.Repositories.ReadRepository;
using GCard.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Abstractions.Storage;
using Utilities.Core.UtilityApplication.Enums;
using T = BaseProject.Domain.Entities.GCard.Definitions;

namespace GCard.Application.Features.Commands.Definitions.StaffFile.Create
{
    public class CreateStaffFileHandler : IRequestHandler<CreateStaffFileRequest, CreateStaffFileResponse>
    {
        readonly IStaffFileWriteRepository _staffFileWriteRepository;
        readonly IStorageService _storageService; 
        readonly IStaffReadRepository _staffReadRepository;
        readonly IStaffWriteRepository _staffWriteRepository;

        public CreateStaffFileHandler(IStaffFileWriteRepository staffFileWriteRepository, IStorageService storageService, IStaffReadRepository staffReadRepository, IStaffWriteRepository staffWriteRepository)
        {
            _staffFileWriteRepository = staffFileWriteRepository;
            _storageService = storageService; 
            _staffReadRepository = staffReadRepository;
            _staffWriteRepository = staffWriteRepository;
        }

        public async Task<CreateStaffFileResponse> Handle(CreateStaffFileRequest request, CancellationToken cancellationToken)
        {  
            var uploadedDatas = await _storageService.UploadAsync("Staff-Files", request.Files);

            T.Staff staff = await _staffReadRepository.GetByIdAsync(request.Id);

            await _staffFileWriteRepository.AddRangeAsync(uploadedDatas.Select(r => new T.Files.StaffFile()
            {
                FileName = r.fileName,
                Path = r.pathOrContainerName,
                Storage = _storageService.StorageName,
                Staffs = new List<T.Staff>() { staff }
            }).ToList());

            await _staffWriteRepository.SaveAsync();

            return new()
            {
                Message = CommandResponseMessage.AddedSuccess.ToString()
            };
        }
    }
}
