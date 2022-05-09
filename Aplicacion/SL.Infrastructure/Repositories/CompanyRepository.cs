using SL.Contracts.Repositories;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Infrastructure.Repositories
{
    public class CompanyRepository : GenericRepository<CompanyModel>, ICompanyRepository
    {
        public CompanyRepository(ServiceLayerDbContext context) : base(context)
        {

        }
    }
}
