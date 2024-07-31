﻿using BaseProject.Domain.Entities.GCard.Definitions;
using BaseProject.Persistence.Contexts;
using GCard.Application.Repositories.WriteRepository;
using T = Utilities.Infrastructure.UtilityPersistence.Repositories;

namespace GCard.Persistence.Repositories.WriteRepository
{
    public class SocialMediaUrlWriteRepository : T.WriteRepository<BaseProjectDbContext, SocialMediaUrl>, ISocialMediaUrlWriteRepository
    {
        public SocialMediaUrlWriteRepository(BaseProjectDbContext context) : base(context)
        {
        }
    }
}