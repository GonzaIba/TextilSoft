using Microsoft.Extensions.Configuration;
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
    public class CompanyService : GenericService<CompanyModel>, ICompanyService
    {
        public CompanyService(IUnitOfWork unitOfWork)
        : base(unitOfWork, unitOfWork.GetRepository<ICompanyRepository>())
        {
            
        }

        public bool ExistCompany(int companyId, string companyApiKey)
        {
            var Result =_repository.Get(x => x.CompanyId == companyId && x.CompanyApiKey == companyApiKey).FirstOrDefault();
            if (Result == null)
                return false;
            else
                return true;
        }
    }
}
