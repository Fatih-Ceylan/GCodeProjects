﻿using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.ReadRepository;
using Microsoft.EntityFrameworkCore;
using Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.ReadRepository
{
    public class StaffReadRepository : ReadRepository<BaseProjectDbContext, Staff>, IStaffReadRepository
    {
        public StaffReadRepository(BaseProjectDbContext context) : base(context)
        {

        }

        public async Task<Staff> GetByEmailAsync(string email, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();

            return await query.Where(x=>x.IsDeleted==false).FirstOrDefaultAsync(data => data.Email == email);
        }

        public async Task<Staff> GetByUserNameAsync(string userName, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();

            return await query.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(data => data.UserName == userName);
        }
    }
}
