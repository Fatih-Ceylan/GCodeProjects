using BaseProject.Domain.Entities.GHR.Recruitment.Recruit;
using BaseProject.Persistence.Contexts;
using GHR.Application.Repositories.WriteRepository;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GHR.Persistence.Repositories.WriteRepository
{
    public class NotesWriteRepository : WriteRepository<BaseProjectDbContext, Notes>, INotesWriteRepository
    {
        public NotesWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}
