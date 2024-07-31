using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Application.Features.Queries.Definitions.Company.GetAll
{
    public class CompanyGetAllResponse
    {
        public int TotalCount { get; set; }

        public object Companies { get; set; }
    }
}
