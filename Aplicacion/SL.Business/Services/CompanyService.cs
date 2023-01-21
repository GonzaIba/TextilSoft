using Microsoft.Extensions.Configuration;
using SL.Contracts;
using SL.Contracts.Repositories;
using SL.Contracts.Services;
using SL.Domain.Entities;
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
        private readonly ICompanyAuthenticationRepository _companyAuthenticationRepository;
        public CompanyService(IUnitOfWork unitOfWork)
        : base(unitOfWork, unitOfWork.GetRepository<ICompanyRepository>())
        {
            _companyAuthenticationRepository = unitOfWork.GetRepository<ICompanyAuthenticationRepository>();
        }

        public bool ExistCompany(int companyId, string companyApiKey)
        {
            var Result = _repository.Get(x => x.CompanyId == companyId && x.CompanyApiKey == companyApiKey).FirstOrDefault();
            if (Result == null)
                return false;
            else
                return true;
        }
        
        public bool CanUseLoginAndRegister(int companyId) => _companyAuthenticationRepository.Get(x => x.CompanyId == companyId).FirstOrDefault().CanUseLoginAndRegister;

        public CompanyAuthenticationModel ObtenerConfigAutenticacion(int companyId) => _companyAuthenticationRepository.Get(x => x.CompanyId == companyId,includeProperties: "CompanyPasswordConfig").FirstOrDefault();
    }
}
