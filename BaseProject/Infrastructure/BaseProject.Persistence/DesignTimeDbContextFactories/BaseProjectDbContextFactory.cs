using BaseProject.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Persistence.DesignTimeDbContextFactories
{
    public class BaseProjectDbContextFactory : IDesignTimeDbContextFactory<BaseProjectDbContext>
    {
        readonly BaseProjectDbContext _baseProjectDbContext;
        readonly IHttpContextAccessor _httpContextAccessor;

        public BaseProjectDbContextFactory(BaseProjectDbContext baseProjectDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _baseProjectDbContext = baseProjectDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public BaseProjectDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<BaseProjectDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(_baseProjectDbContext.DynamicConnectionString);
            return new(dbContextOptionsBuilder.Options, _httpContextAccessor);
        }
    }
}