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
using SL.Domain.Model;
using System.Drawing;

namespace SL.Helper.Controllers
{
    public class CompanyController : ICompanyController
    {
        private readonly ICompanyService _companyService;
        private readonly ICompanyPasswordConfigService _companyPasswordConfigService;
        private readonly ICompanyAuthenticationService _companyAuthenticationService;
        private readonly ICompanyCustomizeService _companyCustomizeService;
        private readonly CompanyConfiguration _companyConfiguration;     
        private readonly IMapper _mapper;

        public CompanyController(
            CompanyConfiguration companyConfiguration,
            ICompanyService companyService,
            ICompanyPasswordConfigService companyPasswordConfigService,
            ICompanyAuthenticationService companyAuthenticationService,
            ICompanyCustomizeService companyCustomizeService,
            IMapper mapper
            )
        {
            _companyConfiguration = companyConfiguration;
            _companyService = companyService;
            _companyPasswordConfigService = companyPasswordConfigService;
            _companyAuthenticationService = companyAuthenticationService;
            _companyCustomizeService = companyCustomizeService;
            _mapper = mapper;
        }

        public bool CanUseLoginAndRegister() => _companyService.CanUseLoginAndRegister(_companyConfiguration.CompanyId);

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
            if (CompanyCustomize == null)
                throw new Exception("No se pudo obtener los datos de la compañía");

            CompanyCustomizeEntity companyCustomizeEntity = _mapper.Map<CompanyCustomizeEntity>(CompanyCustomize);
            if (CompanyCustomize.CompanyCustomize.CompanyColor == null)
                CompanyCustomize.CompanyCustomize.CompanyColor = "White";
            
            return companyCustomizeEntity;
        }

        public void SaveAuthenticationConfig(AuthenticationConfig authenticationConfig)
        {
            //var companyAuthenticationModel = _mapper.Map<CompanyAuthenticationModel>(authenticationConfig);
            var companyAuthenticationModel = _companyAuthenticationService.Get(x => x.CompanyId == _companyConfiguration.CompanyId, tracking: true).FirstOrDefault();
            if (companyAuthenticationModel == null)
                throw new Exception("No se pudo guardar las preferencias de authenticación de la compañía");

            companyAuthenticationModel.SignInRequireConfirmedAccount = authenticationConfig.SignInRequireConfirmedAccount;
            companyAuthenticationModel.MaxFailedAccessAttempts = authenticationConfig.MaxFailedAccessAttempts;
            _companyAuthenticationService.Actualizar(companyAuthenticationModel);

        }

        public void SaveCustomizeCompany(CompanyCustomizeEntity companyCustomizeEntity)
        {
            var CompanyCustomizeModel = _companyCustomizeService.Get(x => x.CompanyId == _companyConfiguration.CompanyId, tracking:true).FirstOrDefault();
            if (CompanyCustomizeModel == null)
                throw new Exception("No se pudo guardar la personalización de la compañía");
            

            if (companyCustomizeEntity.Color.IsNamedColor)
                CompanyCustomizeModel.CompanyColor = companyCustomizeEntity.Color.Name;
            else
                CompanyCustomizeModel.CompanyColor = ColorTranslator.ToHtml(companyCustomizeEntity.Color);
            
            CompanyCustomizeModel.CompanyLogo = companyCustomizeEntity.Logo;
            _companyCustomizeService.Actualizar(CompanyCustomizeModel);
        }

        public void SavePasswordConfig(PasswordConfig passwordConfig)
        {
            var AuthModel = _companyAuthenticationService.Get(x => x.CompanyId == _companyConfiguration.CompanyId, includeProperties: "CompanyPasswordConfig", tracking:false).FirstOrDefault();
            var passwordConfigModel = _companyPasswordConfigService.Get(x => x.CompanyAuthenticationId == AuthModel.CompanyAuthenticationId && x.CompanyPasswordConfigId == AuthModel.CompanyPasswordConfig.CompanyPasswordConfigId, tracking: true).FirstOrDefault();
            passwordConfigModel.RequireNonAlphanumeric = passwordConfig.RequireNonAlphanumeric;
            passwordConfigModel.RequireDigit = passwordConfig.RequireDigit;
            passwordConfigModel.RequireLowercase = passwordConfig.RequireLowercase;
            passwordConfigModel.RequireUppercase = passwordConfig.RequireUppercase;
            passwordConfigModel.CountLength = passwordConfig.CountLength;
            _companyPasswordConfigService.Actualizar(passwordConfigModel);
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
