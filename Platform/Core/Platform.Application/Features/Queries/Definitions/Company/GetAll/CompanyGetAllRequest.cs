using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Application.Features.Queries.Definitions.Company.GetAll
{
    public class CompanyGetAllRequest :IRequest<CompanyGetAllResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
