using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class CompanyAuthenticationModel
    {
        public int CompanyAuthenticationId { get; set; }
        public int CompanyId { get; set; }
        public bool CanUseLoginAndRegister { get; set; }
        public bool UserRequireUniqueEmail { get; set; }
        public bool SignInRequireConfirmedAccount { get; set; }
        public int MaxFailedAccessAttempts { get; set; }

        public CompanyModel Company { get; set; }
        public CompanyPasswordConfigModel CompanyPasswordConfig { get; set; }
    }
}
