using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class CompanyPasswordConfigModel
    {
        public int CompanyPasswordConfigId { get; set; }
        public int CompanyAuthenticationId { get; set; }
        public int CountLength { get; set; }
        public bool RequireNonAlphanumeric { get; set; }
        public bool RequireLowercase { get; set; }
        public bool RequireUppercase { get; set; }
        public bool RequireDigit { get; set; }

        public CompanyAuthenticationModel CompanyAuthentication { get; set; }
    }
}
