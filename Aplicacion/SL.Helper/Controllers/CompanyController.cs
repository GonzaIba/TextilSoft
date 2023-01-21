using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Helper.Configurations;
using SL.Contracts;
using SL.Contracts.Services;
using SL.Domain.Entities;
using AutoMapper;

namespace SL.Helper.Controllers
{
    public class CompanyController : ICompanyController
    {
        private readonly ICompanyService _companyService;
        private readonly CompanyConfiguration _companyConfiguration;
        private readonly IMapper _mapper;

        public CompanyController(
            CompanyConfiguration companyConfiguration,
            ICompanyService companyService,
            IMapper mapper
            )
        {
            _companyConfiguration = companyConfiguration;
            _companyService = companyService;
            _mapper = mapper;
        }

        public AuthenticationConfig GetAuthenticationConfig()
        {
            var companyAuthentication = _companyService.ObtenerConfigAutenticacion(_companyConfiguration.CompanyId);
            var authenticationConfig = _mapper.Map<AuthenticationConfig>(companyAuthentication);
            return authenticationConfig;
        }

        public string GetCompanyLogo()
        {
            var CompanyCustomize = _companyService.Get(x => x.CompanyId == _companyConfiguration.CompanyId && x.CompanyApiKey == _companyConfiguration.CompanyApiKey, includeProperties: "CompanyCustomize").FirstOrDefault();
            if (CompanyCustomize != null)
            {
                return CompanyCustomize.CompanyCustomize.CompanyLogo;
            }
            return "No se pudo obtener el logo de la companñia";
        }

        public int GetCurrentCompany()
        {
            return _companyConfiguration.CompanyId;
        }

        public CompanyCustomizeEntity GetCustomizeCompany()
        {
            var CompanyCustomize = _companyService.Get(x => x.CompanyId == _companyConfiguration.CompanyId && x.CompanyApiKey == _companyConfiguration.CompanyApiKey, includeProperties: "CompanyCustomize").FirstOrDefault();
            if (CompanyCustomize != null)
            {
                CompanyCustomizeEntity companyCustomizeEntity = _mapper.Map<CompanyCustomizeEntity>(CompanyCustomize);
                return companyCustomizeEntity;
            }
            throw new Exception("No se pudo obtener el logo de la companñia");
        }
        
        //public Config GetCustomizeCompany()
        //{
        //    var CompanyCustomize = _companyService.Get(x => x.CompanyId == _companyConfiguration.CompanyId && x.CompanyApiKey == _companyConfiguration.CompanyApiKey, includeProperties: "CompanyCustomize").FirstOrDefault();
        //    if (CompanyCustomize != null)
        //    {
        //        CompanyCustomizeEntity companyCustomizeEntity = _mapper.Map<CompanyCustomizeEntity>(CompanyCustomize);
        //        return companyCustomizeEntity;
        //    }
        //    throw new Exception("No se pudo obtener el logo de la companñia");
        //}

        public bool VerifyCompany()
        {
            try
            {
                return _companyService.ExistCompany(_companyConfiguration.CompanyId,_companyConfiguration.CompanyApiKey);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
