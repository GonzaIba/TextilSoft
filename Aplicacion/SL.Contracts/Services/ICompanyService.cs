using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts.Services
{
    public interface ICompanyService : IGenericService<CompanyModel>
    {
        public int CompanyId {get;}
    }
}
