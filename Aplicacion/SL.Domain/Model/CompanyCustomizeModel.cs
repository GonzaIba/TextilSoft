using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class CompanyCustomizeModel
    {
        public int CompanyCustomizeId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyColor { get; set; }
        public bool CanUseLoginAndRegister { get; set; }

        public CompanyModel Company { get; set; }
    }
}
