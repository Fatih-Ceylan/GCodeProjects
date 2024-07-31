using BaseProject.Domain.Entities.GCard.Definitions;
using Utilities.Core.UtilityApplication.Interfaces;

namespace GCard.Application.Repositories.ReadRepository
{
    public interface IStaffContactReadRepository : IReadRepository<StaffContact>
    {
        //Task<StaffContact> GetContactListByStaffId(string id); 
    }
}
