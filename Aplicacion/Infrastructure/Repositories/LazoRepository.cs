using Contracts.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class LazoRepository : GenericRepository<LazoModel>, ILazoRepository
    {
        public LazoRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
