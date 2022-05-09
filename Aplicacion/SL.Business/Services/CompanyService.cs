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
        private readonly IConfiguration _configuration;
        public CompanyService(IUnitOfWork unitOfWork,IConfiguration configuration)
        : base(unitOfWork, unitOfWork.GetRepository<ICompanyRepository>())
        {
            _configuration = configuration;
        }

        public int CompanyId => Convert.ToInt32(_configuration["Company:CompanyId"]);

    }
}
