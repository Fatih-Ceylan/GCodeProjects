using BaseProject.Domain.Entities.GHR.Recruitment.Recruit;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.ReadRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.ReadRepository
{
    public class NotesReadRepository : ReadRepository<BaseProjectDbContext, Notes>, INotesReadRepository
    {
        public NotesReadRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
