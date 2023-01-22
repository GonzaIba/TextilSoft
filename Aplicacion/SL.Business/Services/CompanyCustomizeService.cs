using SL.Contracts;
using SL.Contracts.Repositories;
using SL.Contracts.Services;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Business.Services
{
    public class CompanyCustomizeService : GenericService<CompanyCustomizeModel>, ICompanyCustomizeService
    {
        public CompanyCustomizeService(IUnitOfWork unitOfWork)
        : base(unitOfWork, unitOfWork.GetRepository<ICompanyCustomizeRepository>())
        {

        }
    }
}
