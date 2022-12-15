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
        private readonly ICompanyCustomizeRepository _companyCustomizeRepository;
        public CompanyService(IUnitOfWork unitOfWork, ICompanyCustomizeRepository companyCustomizeRepository)
        : base(unitOfWork, unitOfWork.GetRepository<ICompanyRepository>())
        {
            _companyCustomizeRepository = companyCustomizeRepository;
        }

        public bool ExistCompany(int companyId, string companyApiKey)
        {
            var Result = _repository.Get(x => x.CompanyId == companyId && x.CompanyApiKey == companyApiKey).FirstOrDefault();
            if (Result == null)
                return false;
            else
                return true;
        }
        
        public bool CanUseLoginAndRegister(int companyId) => _companyCustomizeRepository.Get(x => x.CompanyId == companyId).FirstOrDefault().CanUseLoginAndRegister;
    }
}
