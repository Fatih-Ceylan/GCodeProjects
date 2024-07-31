using AutoMapper;
using GCard.Application.Repositories.ReadRepository;
using GCard.Application.Repositories.WriteRepository;
using MediatR;
using Utilities.Core.UtilityApplication.Abstractions.Storage;
using Utilities.Core.UtilityApplication.Enums;

namespace GCard.Application.Features.Commands.Definitions.Staff.Update
{
    public class UpdateStaffHandler : IRequestHandler<UpdateStaffRequest, UpdateStaffResponse>
    {
        readonly IStaffWriteRepository _staffWriteRepository;
        readonly IStaffReadRepository _staffReadRepository;
        readonly IMapper _mapper;
        readonly IStorageService _storageService;

        public UpdateStaffHandler(IStaffWriteRepository staffWriteRepository, IStaffReadRepository staffReadRepository, IMapper mapper, IStorageService storageService)
        {
            _staffWriteRepository = staffWriteRepository;
            _staffReadRepository = staffReadRepository;
            _mapper = mapper;
            _storageService = storageService;
        }
        public async Task<UpdateStaffResponse> Handle(UpdateStaffRequest request, CancellationToken cancellationToken)
        {
            var staff = await _staffReadRepository.GetByIdAsync(request.Id);

            string[] fileName;

            if (staff.ProfilePicturePath != null)
            {
                fileName = staff.ProfilePicturePath.Split('\\') != null ? staff.ProfilePicturePath.Split('\\') : new string[] { "" };

                if (request.ProfilePicturePath == null && request.Files == null)
                {
                    try
                    {
                        await _storageService.DeleteAsync(fileName[0], fileName[1]);

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    staff.ProfilePicturePath = null;
                }
            } 

            if (request.Files != null)
            {
                List<(string fileName, string pathOrContainerName)>? uploadedDatas = null;
                if (request.Files.Count > 0)
                    uploadedDatas = await _storageService.UploadAsync("Staff-ProfilePictures", request.Files);

                request.ProfilePicturePath = uploadedDatas != null ? uploadedDatas.Select(t => t.pathOrContainerName).FirstOrDefault() : null;
            }

            staff = _mapper.Map(request, staff);
            await _staffWriteRepository.SaveAsync();

            var updatedResponse = _mapper.Map<UpdateStaffResponse>(staff);
            updatedResponse.Message = CommandResponseMessage.UpdatedSuccess.ToString();

            return updatedResponse;
        }
    }
}
