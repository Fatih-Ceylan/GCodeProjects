using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Application.Repositories
{
    public interface IPlatformDbContext
    {
        public string DbName { get; set; }
        //IDbContextTransaction PlatformBeginTransaction();

        //void PlatformUseTransaction(IDbContextTransaction transaction);
    }
}
