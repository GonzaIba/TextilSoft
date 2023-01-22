using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts
{
    public interface ICompanyController
    {
        bool VerifyCompany();

        string GetCompanyLogo();

        int GetCurrentCompany();
        
        CompanyCustomizeEntity GetCustomizeCompany();

        AuthenticationConfig GetAuthenticationConfig();

        void SavePasswordConfig(PasswordConfig passwordConfig);
        void SaveCustomizeCompany(CompanyCustomizeEntity passwordConfig);
        bool CanUseLoginAndRegister();
    }
}
